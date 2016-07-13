﻿using System;
using System.Collections.Generic;

namespace ical.NET.Collections
{
    public class ObjectEventArgs<T, TU> :
        EventArgs
    {
        public T First { get; set; }
        public TU Second { get; set; }

        public ObjectEventArgs(T first, TU second)
        {
            First = first;
            Second = second;
        }
    }
}