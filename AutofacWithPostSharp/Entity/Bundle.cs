using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutofacWithPostSharp.Entity
{
    public class Bundle
    {
        public int BundlePk { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public BundleType BundleType { get; set; }
    }
}
