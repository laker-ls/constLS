
namespace ConstLS.Memory.Injections.PacketLists
{
    class PacketList
    {
        public static class action
        {
            public static readonly byte[]
                inMeditation = { 0x2E, 0x00 },
                outMeditation = { 0x2F, 0x00 },
                autoAttack = { 0x03, 0x00, 0x00 },
                flyOnOrOff = { 0x28, 0x00, 0x01, 0x01, 0x0C, 0x00, 0xFF, 0xFF, 0xFF, 0xFF }, // Вместо 0xFF указать id полёта.
                inviteToGroup = { 0x1B, 0x00, 0xFF, 0xFF, 0xFF, 0xFF }, // Вместо 0xFF указать id персонажа.
                leaveGroup = { 0x1E, 0x00 };
        }
        public static class pet
        {
            public static readonly byte[]
                call = { 0x64, 0x00, 0x00, 0x00, 0x00, 0x00 }, // Вызов петомца из первой клетки
                remove = { 0x65, 0x00 },
                atack = { 0x67, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00 }; // 0xFF - WID моба
        }
    }
}
