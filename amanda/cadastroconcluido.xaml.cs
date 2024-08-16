using System;
using Microsoft.Maui.Controls;

namespace amanda
{
    public partial class cadastroconcluido : ContentPage
    {
        public cadastroconcluido()
        {
            InitializeComponent();
            entrarButton.Clicked += OnEntrarButtonClicked;
        }

        private void OnEntrarButtonClicked(object sender, EventArgs e)
        {
            
        }
    }
}
