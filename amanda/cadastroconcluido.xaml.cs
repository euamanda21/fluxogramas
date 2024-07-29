using System;
using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
            entrarButton.Clicked += OnEntrarButtonClicked;
        }

        private void OnEntrarButtonClicked(object sender, EventArgs e)
        {
            // Adicione aqui a lógica do botão "Entrar"
        }
    }
}
