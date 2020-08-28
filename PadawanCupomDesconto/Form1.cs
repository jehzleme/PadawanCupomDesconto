using System;
using System.Windows.Forms;

namespace PadawanCupomDesconto
{
    public partial class Form1 : Form
    {
        private readonly MeuBanco meuBanco;
        public Form1()
        {
            InitializeComponent();
            meuBanco = new MeuBanco();
        }

        private void btn_GerarCupom_Click(object sender, EventArgs e)
        {
            txt_CupomDesconto.Text = Guid.NewGuid().ToString(); //gerador de  código
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteModel()
            {
                Nome = txt_NomeCliente.Text,
                Cpf = txt_Cpf.Text
            };

            var clienteCupom = new ClienteCupomModel()
            {
                Cpf = cliente.Cpf,
                Cupom = txt_CupomDesconto.Text
            };

            txt_Listagem.Text = "";
            meuBanco.Adicionar(cliente);
            meuBanco.Adicionar(clienteCupom);
            var result = meuBanco.Buscar(cliente.Cpf);
            result.ForEach(x =>
            {
                txt_Listagem.Text += x + Environment.NewLine;
            });
        }
    }
}
