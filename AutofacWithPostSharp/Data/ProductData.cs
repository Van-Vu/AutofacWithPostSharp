using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutofacWithPostSharp.Entity;

namespace AutofacWithPostSharp.Data
{
    public class ProductData:IProductData
    {
        public Product Productize(int policyPk, int bundlePk)
        {
            return new Product
                {
                    ProductPk = new Random(50).Next(),
                    Policy = new Policy { PolicyPk = policyPk },
                    Bundle = new Bundle { BundlePk = bundlePk }
                };

        }
    }
}
