using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    internal class VideoHandler
    {
        public void BroadcastVideoFrame(byte[] frame, Socket clientSocket)
        {
            //foreach (var client in connectedClients)
            //{
            //    if (client.Key != fromClientId)
            //    {
            //        try
            //        {
            //            client.Value.Send(frame);
            //        }
            //        catch (SocketException)
            //        {
            //            Console.WriteLine("Failed to send video frame to client " + client.Key);
            //        }
            //    }
            //}

           // Socket clientSocket = connectedClients[fromClientId];
            clientSocket.SendTo(frame, clientSocket.RemoteEndPoint);


        }
    }
}
