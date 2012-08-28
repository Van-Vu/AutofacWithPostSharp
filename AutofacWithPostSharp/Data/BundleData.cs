using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutofacWithPostSharp.Entity;

namespace AutofacWithPostSharp.Data
{
    public class BundleData: IBundleData
    {
        public Bundle CreateBundle()
        {
            return new Bundle{BundlePk = new Random(50).Next()};
        }
    }
}
