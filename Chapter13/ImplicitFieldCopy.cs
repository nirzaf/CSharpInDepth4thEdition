using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.16")]
    class ImplicitFieldCopy
    {
        private readonly YearMonthDay readOnlyField = new YearMonthDay(2018, 3, 1);
        private YearMonthDay readWriteField = new YearMonthDay(2018, 3, 1);

        public void CheckYear()
        {
            int readOnlyFieldYear = readOnlyField.Year;
            int readWriteFieldYear = readWriteField.Year;
        }
    }
}
