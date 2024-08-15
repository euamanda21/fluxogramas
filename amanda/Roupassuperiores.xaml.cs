using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace amanda
{
    public partial class Roupassuperiores : ContentPage
    {
        public Roupassuperiores()
        {
            InitializeComponent();
        }

        private void OpcaoSelecionada(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string opcaoEscolhida = button.Text;
            
            DisplayAlert("Opção Selecionada", $"Você selecionou: {opcaoEscolhida}", "OK");
        }

        private void Navegar(object sender, EventArgs e)
        {
            var button = (Button)sender;
            
            DisplayAlert("Navegação", $"Você clicou em {button.Text}", "OK");
        }

        private void Selecionar(object sender, EventArgs e)
        {
            
            DisplayAlert("Selecionar", "Opção de seleção", "OK");
        }
    }
}