using Microsoft.CSharp.RuntimeBinder;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter04
{
    [Description("Listing 4.8")]
    class DynamicTypingDecompiled
    {
        private static class CallSites
        {
            public static CallSite<Func<CallSite, object, int, object>> method;
            public static CallSite<Func<CallSite, object, string>> conversion;
        }

        static void Main()
        {
            // Original code:
            // dynamic text = "hello world";
            // string world = text.Substring(6);

            object text = "hello world";
            if (CallSites.method == null)
            {
                CSharpArgumentInfo[] argumentInfo = new[]
                {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant | CSharpArgumentInfoFlags.UseCompileTimeType, null)
                };
                CallSiteBinder binder = Binder.InvokeMember(CSharpBinderFlags.None, "Substring", null, typeof(DynamicTypingDecompiled), argumentInfo);
                CallSites.method = CallSite<Func<CallSite, object, int, object>>.Create(binder);
            }
            if (CallSites.conversion == null)
            {
                CallSiteBinder binder = Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(DynamicTypingDecompiled));
                CallSites.conversion = CallSite<Func<CallSite, object, string>>.Create(binder);
            }
            object method = CallSites.method.Target(CallSites.method, text, 6);
            string str = CallSites.conversion.Target(CallSites.conversion, method);
        }
    }
}
