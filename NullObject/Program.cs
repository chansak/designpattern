﻿using NullObject.Factory;
using NullObject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = CustomerFactory.getCustomer("aa");
        }
    }
}
