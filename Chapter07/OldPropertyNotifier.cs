using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter07
{
    class OldPropertyNotifier : INotifyPropertyChanged
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
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Description("Listing 7.4")]
    class PropertyNotificationBeforeCallerInfo
    {
        static void Main()
        {
            var model = new OldPropertyNotifier();
            model.PropertyChanged += (sender, args) =>
                Console.WriteLine("{0} has changed", args.PropertyName);
            model.FirstValue = 10;
            model.FirstValue = 20;
        }
    }
}
