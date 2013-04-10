﻿using System.Net;

namespace WPPlayer.Models
{
    public class Server
    {
        public string Name { get; set; }
        public IPEndPoint EndPoint { get; set; }

        public override string ToString()
        {
            return "Test" + Name + EndPoint;
        }
    }
}
