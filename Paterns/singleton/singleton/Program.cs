﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Single fr= Single.getInstance();
            fr.Inform();
        }
    }
}