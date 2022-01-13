using System.ComponentModel;

namespace Chapter02
{
    class FixedBuffersInFields
    {
        unsafe struct VersionedData
        {
            public int Major;
            public int Minor;
            public fixed byte Data[16];
        }

        static VersionedData field;

        unsafe static void Main()
        {
            field = new VersionedData();
            field.Major = 2;
            field.Minor = 1;
            field.Data[10] = 20;
        }
    }
}
