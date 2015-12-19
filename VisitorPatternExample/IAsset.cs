﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample
{
    public interface IAsset
    {
        void Accept(IVisitor vistor);
    }
}
