using System;
using System.ComponentModel;

namespace Chapter14
{
    enum SampleEnum { }

    [Description("Listing 14.12")]
    class GenericConstraints
    {
        static void EnumMethod<T>() where T : struct, Enum
        {
        }

        static void DelegateMethod<T>() where T : Delegate
        {
        }

        static void UnmanagedMethod<T>() where T : unmanaged
        {
        }

        static void Main()
        {
            EnumMethod<SampleEnum>();
            // EnumMethod<Enum>();
            DelegateMethod<Action>();
            DelegateMethod<Delegate>();
            DelegateMethod<MulticastDelegate>();

            UnmanagedMethod<int>();
            //UnmanagedMethod<string>();
        }
    }
}
