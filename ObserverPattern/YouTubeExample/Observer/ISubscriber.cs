﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.YouTubeExample.Observer
{
    public interface ISubscriber
    {
        string Name { get; }
        void Notify();
    }
}
