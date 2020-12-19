﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/**
 * Данный класс по работе с хуками был взят в ответе stackoverflow.
 * Автор Нина Лисицинская https://ru.stackoverflow.com/users/264984/%d0%9d%d0%b8%d0%bd%d0%b0-%d0%9b%d0%b8%d1%81%d0%b8%d1%86%d0%b8%d0%bd%d1%81%d0%ba%d0%b0%d1%8f
 * 
 * Удалил хуки для мыши (при остановке процесса на брейкпоинте в течении нескольких секунд тормозил указатель мыши).
 */

namespace ConstLS.KeyAndMouseHook
{
    public sealed class GlobalHook : IDisposable
    {
        // Импортируем необходимые функции WinAPI, объявляем нужные для них структуры и константы
        private static class WinAPI
        {
            public static class Kernel32
            {
                [DllImport("kernel32")]
                public static extern IntPtr LoadLibrary(string lpFileName);
            }

            public static class User32
            {
                // KBDLLHOOKSTRUCT
                // https://msdn.microsoft.com/ru-ru/library/windows/desktop/ms644967(v=vs.85).aspx
                public struct KeyboardHookStruct
                {
                    public uint VKCode;
                    public uint ScanCode;
                    public uint Flags;
                    public uint Time;
                    public IntPtr dwExtraInfo;
                }

                // Константы WH_*
                public enum WindowsHook : int
                {
                    KeyboardLowLevel = 13,
                }

                // Константы WM_*
                public enum WindowsMessage : int
                {
                    KeyDown = 0x100,
                    KeyUp = 0x101,

                    SysKeyDown = 0x104,
                    SysKeyUp = 0x105,

                    MouseMove = 0x200,
                    LeftButtonDown = 0x201,
                    LeftButtonUp = 0x202,

                    RightButtonDown = 0x204,
                    RightButtonUp = 0x205,

                    MiddleButtonDown = 0x207,
                    MiddleButtonUp = 0x208,
                }

                public delegate int KeyboardHookProc(int code,
                    WindowsMessage wParam, ref KeyboardHookStruct lParam);

                [DllImport("user32")]
                public static extern int CallNextHookEx(IntPtr hHk, int nCode,
                    WindowsMessage wParam, ref KeyboardHookStruct lParam);

                [DllImport("user32")]
                public static extern IntPtr SetWindowsHookEx(WindowsHook idHook,
                    KeyboardHookProc lpfn, IntPtr hMod, uint dwThreadId);

                [DllImport("user32")]
                public static extern bool UnhookWindowsHookEx(IntPtr hHk);
            }
        }

        // Дескрипторы хуков
        private readonly IntPtr _keyboardHookHandle;

        // Хуки
        private readonly WinAPI.User32.KeyboardHookProc _keyboardCallback;

        // События
        public event KeyEventHandler KeyDown = (s, e) => { };
        public event KeyEventHandler KeyUp = (s, e) => { };

        public GlobalHook()
        {
            // Создадим колбэки и сохраним их в полях класса, чтобы их не собрал GC
            _keyboardCallback = new WinAPI.User32.KeyboardHookProc((int code,
                WinAPI.User32.WindowsMessage wParam, ref WinAPI.User32.KeyboardHookStruct lParam) =>
            {
                // Если code < 0, мы не должны обрабатывать это сообщение системы
                if (code >= 0) {
                    var key = (Keys)lParam.VKCode;
                    var eventArgs = new KeyEventArgs(key);

                    // В зависимости от типа пришедшего сообщения вызовем то или иное событие
                    switch (wParam) {
                        case WinAPI.User32.WindowsMessage.KeyDown:
                        case WinAPI.User32.WindowsMessage.SysKeyDown:
                            KeyDown(this, eventArgs);
                            break;

                        case WinAPI.User32.WindowsMessage.KeyUp:
                        case WinAPI.User32.WindowsMessage.SysKeyUp:
                            KeyUp(this, eventArgs);
                            break;
                    }

                    // Если событие помечено приложением как обработанное,
                    // прервём дальнейшее распространение сообщения
                    if (eventArgs.Handled)
                        return 1;
                }

                // Вызовем следующий обработчик
                return WinAPI.User32.CallNextHookEx(_keyboardHookHandle, code, wParam, ref lParam);
            });

            // В SetWindowsHookEx следует передать дескриптор библиотеки user32.dll
            // Библиотека user32 всё равно всегда загружена в приложениях .NET,
            // хранить и освобождать дескриптор или что-либо ещё с ним делать нет необходимости
            IntPtr user32Handle = WinAPI.Kernel32.LoadLibrary("user32");

            // Установим хуки
            _keyboardHookHandle = WinAPI.User32.SetWindowsHookEx(
                WinAPI.User32.WindowsHook.KeyboardLowLevel, _keyboardCallback, user32Handle, 0);
        }

        #region IDisposable implementation

        private bool _isDisposed = false;

        public bool IsDisposed { get { return _isDisposed; } }

        public void Dispose()
        {
            if (_isDisposed)
                return;

            _isDisposed = true;

            // Удалим хуки
            WinAPI.User32.UnhookWindowsHookEx(_keyboardHookHandle);
        }

        ~GlobalHook()
        {
            Dispose();
        }

        #endregion
    }
}
