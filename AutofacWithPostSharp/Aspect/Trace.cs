using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PostSharp.Aspects;

namespace AutofacWithPostSharp.Aspect
{
    [Serializable]
    public class Trace : OnMethodBoundaryAspect
    {
        private string enteringMessage, leavingMessage;

        public override void CompileTimeInitialize(System.Reflection.MethodBase method, AspectInfo aspectInfo)
        {
            string methodName = method.DeclaringType.FullName + "." + method.Name;
            this.enteringMessage = "Entering " + methodName;
            this.leavingMessage = "Leaving " + methodName;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine(this.enteringMessage);
            
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine(this.leavingMessage);
        }
    }
}
