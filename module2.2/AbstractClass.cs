using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2._2
{
    public  class AbstractClass
    {
        public int IdProd;
        public decimal Size;
        public int quantity;

        public AbstractClass(int id, decimal size, int q) { 
            this.IdProd = id;
            this.Size = size;
            this.quantity = q;
        }

    }
}
