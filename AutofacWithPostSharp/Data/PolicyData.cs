using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutofacWithPostSharp.Entity;

namespace AutofacWithPostSharp.Data
{
    public class PolicyData: IPolicyData
    {
        public Policy CreatePolicy()
        {
            return new Policy { PolicyPk = new Random(50).Next() };
        }
    }
}
