using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace amanda
{
    public partial class Vestidos : ContentPage
    {
        public Vestidos()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs   e)
        {
            
            var button = (Button)sender;
            string vestidoSelecionado = button.Text;
        }

        private void NavigationButton_Clicked(object sender, EventArgs e)
        {
           
        }

        private void SelecionarButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}