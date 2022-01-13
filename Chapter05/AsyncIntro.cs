using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace Chapter05
{
    [Description("Listing 5.1")]
    public class AsyncIntro : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly Label label;
        private readonly Button button;

        public AsyncIntro()
        {
            label = new Label
            {
                Location = new Point(10, 20),
                Text = "Length"
            };
            button = new Button
            {
                Location = new Point(10, 50),
                Text = "Click"
            };
            button.Click += DisplayWebSiteLength;
            AutoSize = true;
            Controls.Add(label);
            Controls.Add(button);
        }

        async void DisplayWebSiteLength(object sender, EventArgs e)
        {
            label.Text = "Fetching...";
            string text = await client.GetStringAsync("http://csharpindepth.com");
            label.Text = text.Length.ToString();
        }

        static void Main()
        {
            Application.Run(new AsyncIntro());
        }
    }
}
