using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Chapter07
{
    using MDA = MemberDescriptionAttribute;

    // Listing 7.9
    [AttributeUsage(AttributeTargets.All)]
    public class MemberDescriptionAttribute : Attribute
    {
        public MemberDescriptionAttribute(
            [CallerFilePath] string file = "Unspecified file",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "Unspecified member")
        {
            File = file;
            Line = line;
            Member = member;
        }

        public string File { get; }
        public int Line { get; }
        public string Member { get; }

        public override string ToString() =>
            $"{Path.GetFileName(File)}:{Line} - {Member}";
    }

    [Description("Listing 7.10")]
    [MemberDescription]
    class CallerNameInAttribute
    {
        [MemberDescription]
        public void Method<[MemberDescription] T>([MemberDescription] int parameter) { }

        static void Main()
        {
            var typeInfo = typeof(CallerNameInAttribute).GetTypeInfo();
            var methodInfo = typeInfo.GetDeclaredMethod("Method");
            var paramInfo = methodInfo.GetParameters()[0];
            var typeParamInfo = methodInfo.GetGenericArguments()[0].GetTypeInfo();
            Console.WriteLine(typeInfo.GetCustomAttribute<MDA>());
            Console.WriteLine(methodInfo.GetCustomAttribute<MDA>());
            Console.WriteLine(paramInfo.GetCustomAttribute<MDA>());
            Console.WriteLine(typeParamInfo.GetCustomAttribute<MDA>());
        }
    }
}
