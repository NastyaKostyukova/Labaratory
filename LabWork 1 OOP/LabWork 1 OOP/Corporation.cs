using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1_OOP
{
    class Corporation
    {
        public string Name { get; set; }
        public List<Product> LProduct { get; set; }

        public Corporation()
        {
            LProduct = new List<Product>();
        }
    }
}
