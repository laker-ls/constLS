using System;
using ConstLS.Memory.Offsets.GameServers;

namespace ConstLS.Memory.Offsets
{
    class Offset {
        private Offset() {}
        private static IGameServerOffset instance;
        private static string setServer;

        public static void setGameServer(string serverName)
        {
            Offset.setServer = serverName.ToUpper();
        }

        public static IGameServerOffset get()
        {
            if (Offset.instance == null) {
                if (Offset.setServer.IndexOf("cloudy".ToUpper()) != -1) {
                    Offset.instance = new cloudy();
                } else if (Offset.setServer.IndexOf("pw_pvp".ToUpper()) != -1) {
                    Offset.instance = new pw_pvp();
                } else if (Offset.setServer.IndexOf("pwclassic_net".ToUpper()) != -1) {
                    Offset.instance = new pwclassic_net();
                } else {
                    Offset.instance = null;
                }
            }
            return Offset.instance;
        }
    }
}
