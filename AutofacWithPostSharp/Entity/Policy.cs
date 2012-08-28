using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutofacWithPostSharp.Entity
{
    public class Policy
    {
        public int PolicyPk { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public OfferType OfferType { get; set; }
    }
}
