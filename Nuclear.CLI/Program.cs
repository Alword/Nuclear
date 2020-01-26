using System;
using Transmission.API.RPC;
using Transmission.API.RPC.Entity;

namespace Almanac.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client("http://127.0.0.1:9091/transmission/rpc", "", "username", "password");

            var sessionInfo = client.GetSessionInformation();
            var allTorrents = client.TorrentGet(TorrentFields.ALL_FIELDS);
            Console.WriteLine("Hello World!");
        }
    }
}
