using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter07
{
    class NewPropertyNotifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int firstValue;
        public int FirstValue
        {
            get { return firstValue; }
            set
            {
                if (value != firstValue)
                {
                    firstValue = value;
                    NotifyPropertyChanged("FirstValue");
                }
            }
        }
        // Other properties with the same pattern
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Description("Listing 7.5")]
    class PropertyNotificationAfterCallerInfo
    {
        static void Main()
        {
            var model = new NewPropertyNotifier();
            model.PropertyChanged += (sender, args) =>
                Console.WriteLine("{0} has changed", args.PropertyName);
            model.FirstValue = 10;
            model.FirstValue = 20;
        }
    }
}
