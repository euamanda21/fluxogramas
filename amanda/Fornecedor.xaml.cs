using System;
using Microsoft.Maui.Controls;

namespace amanda
{
    public partial class Fornecedor : ContentPage
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
           
            DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Cancelar", "Operação cancelada", "OK");
        }
    }
}
