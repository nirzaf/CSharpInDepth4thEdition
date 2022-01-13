using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.3")]
    class RefLocalArrays
    {
        static void Main()
        {
            var array = new (int x, int y)[10];
            // First initialize the array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i, i);
            }

            // Then increment x and double y for each 
            // element in the array
            for (int i = 0; i < array.Length; i++)
            {
                ref var element = ref array[i];
                element.x++;
                element.y *= 2;
            }
        }
    }
}
