using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    public class Subscriber : IObserver
    {
        private TwitchChannel observable;

        public Subscriber(TwitchChannel observable)
        {
            this.observable = observable;
        }
        public  void Update()
        {
            Console.WriteLine("Live ");
            Console.WriteLine(this.observable.GetLastStreamTittle());
        }
    }
}
