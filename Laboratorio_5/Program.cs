using System;
using System.Collections.Generic;

namespace Laboratorio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TwitchChannel channel = new TwitchChannel();
            Subscriber s1 = new Subscriber(channel);
            Subscriber s2 = new Subscriber(channel);

            channel.Attach(s1);
            channel.Attach(s2);
            channel.AddNewVideo("Video Warzone");
        }
    }
    
    
    
}
