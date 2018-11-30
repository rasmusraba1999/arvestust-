using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Rasmus_Raba
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public int counter { get; private set; }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate((Type)typeof(Content.xaml), null);
        }
        {
            string Kasutajanimi = "user";
            string Parool = "SecretPassword";

            if (counter <= 3)
            {
                if (userBox.Text == Kasutajanimi && passwordBox.Password == Parool)
                {
                    resultBlock.Text = "Sisselogimine õnnestus";
                }
                else
                {
                    resultBlock.Text = "Sisselogimine ebaõnnestus";
                    counter++;
                }
            }
            else
            {
                resultBlock.Text = "Sisselogimine ebaõnnestus." +
                    " Rohkem katseid sisenemiseks ei ole";
                button1.IsEnabled = false;
            }
        }

    }
}
