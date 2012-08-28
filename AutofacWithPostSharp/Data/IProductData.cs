using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutofacWithPostSharp.Entity;

namespace AutofacWithPostSharp.Data
{
    public interface IProductData
    {
        Product Productize(int policyPk, int bundlePk);
    }
}
