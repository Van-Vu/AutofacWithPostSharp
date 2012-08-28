using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutofacWithPostSharp.Entity;

namespace AutofacWithPostSharp.BusService
{
    public interface IProductionService
    {
        Bundle CreateBundle();

        Policy CreatePolicy();

        Product Productize(int policyId, int bundleId);
    }
}
