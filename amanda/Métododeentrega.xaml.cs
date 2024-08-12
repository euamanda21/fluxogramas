using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace amanda
{
    public partial class  Métododeentrega : ContentPage
    {
        private string opcaoEntregaSelecionada;

        public  Métododeentrega()
        {
            InitializeComponent();
        }

        private void OpcaoEntrega_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            opcaoEntregaSelecionada = button.Text;
        }

        private void Selecionar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Opção Selecionada", $"Você escolheu a opção: {opcaoEntregaSelecionada}", "OK");
        }
    }
}