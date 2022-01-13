using System.Reflection;

using static System.Reflection.BindingFlags;

namespace Chapter10
{
    class CombineEnums
    {
        static void Main()
        {
            var fields = typeof(CombineEnums).GetFields(Instance | Static | Public | NonPublic);
        }
    }
}
