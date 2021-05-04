using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    public abstract class Observable
    {
        public abstract void Attach(IObserver ob);
        public abstract void Detach(IObserver ob);
        public abstract void Notify();

    }
}
