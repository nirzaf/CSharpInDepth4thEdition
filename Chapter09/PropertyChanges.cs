using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter09
{
    [Description("Listing 9.14")]
    public class Rectangle : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (width == value)
                {
                    return;
                }
                width = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Area));
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (height == value)
                {
                    return;
                }
                height = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Area));
            }
        }

        public double Area => Width * Height;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    class PropertyChanges
    {
        static void Main()
        {
            var rect = new Rectangle();
            rect.PropertyChanged += (sender, e) => Console.WriteLine(e.PropertyName);
            rect.Height = 20;
            rect.Width = 15;
        }
    }
}
