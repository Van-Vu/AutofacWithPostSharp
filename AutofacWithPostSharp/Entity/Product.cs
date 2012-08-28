using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutofacWithPostSharp.Entity
{
    public class Product
    {
        public int ProductPk { get; set; }

        public Policy Policy { get; set; }

        public Bundle Bundle { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
    }
}
