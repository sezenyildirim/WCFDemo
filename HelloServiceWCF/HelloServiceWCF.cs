﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloServiceWCF" in both code and config file together.
    public class HelloServiceWCF : IHelloServiceWCF
    {
       

        public string GetMessage(string name)
        {
           return "Hello " + name;
        }
    }
}
