using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.26")]
    class FixedBuffers
    {
        unsafe struct VersionedData
        {
            public int Major;
            public int Minor;
            public fixed byte Data[16];
        }

        unsafe static void Main()
        {
            var versioned = new VersionedData();
            versioned.Major = 2;
            versioned.Minor = 1;
            versioned.Data[10] = 20;
        }
    }
}
