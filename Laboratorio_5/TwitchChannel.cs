using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    public class TwitchChannel : Observable
    {
        private List<IObserver> _channelSubscraibers = new List<IObserver>();
        private string _lastVideoPosted = "";
        public override void Attach(IObserver ob)
        {
            _channelSubscraibers.Add(ob);
        }

        public override void Notify()
        {
            foreach (IObserver suscriptor in this._channelSubscraibers)
            {
                suscriptor.Update();
            }
        }
        public void AddNewVideo(string tittle)
        {
            this._lastVideoPosted = tittle;
            this.Notify();
            Console.WriteLine("New youtube video channel");
        }
        public string GetLastVideoTittle()
        {
            return this._lastVideoPosted;
        }

        public override void Detach(IObserver ob)
        {
            _channelSubscraibers.Remove(ob);
        }
    }
}
