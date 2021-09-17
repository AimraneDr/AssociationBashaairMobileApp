using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        int i = 0;
        public HomePage()
        {
            InitializeComponent();
            main_label.Text = $"integer : {i}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            i++;
            main_label.Text = $"integer : {i}";
        }
    }
}