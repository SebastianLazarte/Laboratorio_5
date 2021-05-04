using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    public class TwitchChannel : Observable
    {
        private List<IObserver> _channelSubscribers = new List<IObserver>();
        private string _lastStreamPosted = "";

        public override void Attach(IObserver ob)
        {
            _channelSubscribers.Add(ob);
        }
        public override void Detach(IObserver ob)
        {
            _channelSubscribers.Remove(ob);
        }
        public void AddNewStream(string tittle)
        {
            this._lastStreamPosted = tittle;
            this.Notify();
            Console.WriteLine("Streaming Now");
        }
        public string GetLastStreamTittle()
        {
            return this._lastStreamPosted;
        }
        public override void Notify()
        {
            foreach (IObserver suscriptor in this._channelSubscribers)
            {
                suscriptor.Update();
            }
        }
        
    }
}
