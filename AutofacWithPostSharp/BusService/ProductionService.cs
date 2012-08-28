using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutofacWithPostSharp.Aspect;
using AutofacWithPostSharp.Data;
using AutofacWithPostSharp.Entity;

using ContactManager.Aspects;

namespace AutofacWithPostSharp.BusService
{
    [ExceptionDialog]
    [Trace]
    public class ProductionService : IProductionService
    {
        private IBundleData bundleDataAccess;

        private IPolicyData policyDataAccess;

        private IProductData productDataAccess;

        public ProductionService(IBundleData bundleData, IPolicyData policyData, IProductData productData)
        {
            bundleDataAccess = bundleData;
            policyDataAccess = policyData;
            productDataAccess = productData;
        }

        public Bundle CreateBundle()
        {
            //throw new Exception("this is the exception");
            return bundleDataAccess.CreateBundle();
            
        }

        //public void DeactivateBundle(Bundle bundle)
        //{

        //}

        //public void DeleteBundle(Bundle bundle)
        //{

        //}

        public Policy CreatePolicy()
        {
            return policyDataAccess.CreatePolicy();
        }

        //public void UpdatePolicy(Policy policy)
        //{

        //}

        //public void DeletePolicy(Policy policy)
        //{

        //}

        public Product Productize(int policyId, int bundleId)
        {
            return productDataAccess.Productize(policyId, bundleId);
        }

        //public void UpdateProduct(Product product)
        //{

        //}
    }
}
