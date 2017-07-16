using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.Converter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnConverter.Clicked += BtnConverter_Clicked;
        }

        private void BtnConverter_Clicked(object sender, EventArgs e)
        {
            if(txtValorOrigem.Text == null) return;
            

            double valor1 = Convert.ToDouble(txtValorOrigem.Text);

            txtValorConvertido.Text = "US$ " + (Math.Round( valor1 / 3.20, 2)).ToString();

        }
    }
}
