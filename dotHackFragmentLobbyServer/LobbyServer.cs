using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;

namespace dotHackFragmentLobbyServer
{
   public static class LobbyServer
    {
        public static Thread processThread;
        public static bool _exit = false;
        public static bool _proxyMopde = false;
        public static string proxyIP;
        public static readonly object _sync = new object();
        public static List<GameClient> clients;
        public static List<ProxyClient> proxies;
        public static List<LobbyChatRoom> lobbyChatRooms;
        public static TcpListener listener;


        public static void StartLobbyServer()
        {

        }
    }
}
