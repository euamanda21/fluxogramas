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
            // Aqui você pode implementar a lógica para quando uma opção é selecionada
            // Por exemplo: exibir detalhes da opção, adicionar ao carrinho, etc.
            DisplayAlert("Opção Selecionada", $"Você selecionou: {opcaoEscolhida}", "OK");
        }

        private void Navegar(object sender, EventArgs e)
        {
            var button = (Button)sender;
            // Aqui você pode implementar a lógica para navegar entre as opções
            // Por exemplo: mostrar mais opções, filtrar por categoria, etc.
            DisplayAlert("Navegação", $"Você clicou em {button.Text}", "OK");
        }

        private void Selecionar(object sender, EventArgs e)
        {
            // Aqui você pode implementar a lógica para quando o botão "selecionar" é clicado
            // Por exemplo: confirmar a seleção, direcionar para a página de pagamento, etc.
            DisplayAlert("Selecionar", "Opção de seleção", "OK");
        }
    }
}