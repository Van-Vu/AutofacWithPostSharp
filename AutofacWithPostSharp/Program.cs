using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autofac;

using AutofacWithPostSharp.BusService;
using AutofacWithPostSharp.Data;

namespace AutofacWithPostSharp
{
    class Program
    {
        private static IContainer container;

        static void Main(string[] args)
        {
            SetupContainer();

            var service = container.Resolve<ProductionService>();

            var bundleEntity = service.CreateBundle();
            var policyEntity = service.CreatePolicy();
            var productEntity = service.Productize(policyEntity.PolicyPk,bundleEntity.BundlePk);
        }

        private static void SetupContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BundleData>().As<IBundleData>();
            builder.RegisterType<PolicyData>().As<IPolicyData>();
            builder.RegisterType<ProductData>().As<IProductData>();
            builder.Register(c => new ProductionService(c.Resolve<IBundleData>(), c.Resolve<IPolicyData>(), c.Resolve<IProductData>()));

            container = builder.Build();
        }
    }
}
