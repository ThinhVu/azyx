using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L1.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public class DbTableAttribute : Attribute
    {
        public string Name { get; set; }
        public DbTableAttribute(string name) : base()
        {
            Name = name;
        }
    }
}
