using System;
using System.Windows.Forms;

namespace CentralAtendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas;
        private Guiches guiches;

        public Form1()
        {
            InitializeComponent();

            senhas = new Senhas();
            guiches = new Guiches();

            atualizarSenhas();
            atualizarGuiches();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();

            atualizarSenhas();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtQuantidade.Text);

            int inicio = guiches.getListaGuiches().Count + 1;

            for (int i = 0; i < quantidade; i++)
            {
                Guiche guiche = new Guiche(inicio + i);

                guiches.adicionar(guiche);
            }

            atualizarGuiches();

            txtQuantidade.Clear();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            if (cmbGuiche.SelectedItem == null)
            {
                MessageBox.Show("Selecione um guichê.");
                return;
            }

            int idGuiche = int.Parse(cmbGuiche.SelectedItem.ToString());

            Guiche guiche = guiches.buscar(idGuiche);

            if (guiche == null)
            {
                MessageBox.Show("Guichê não encontrado.");
                return;
            }

            bool sucesso = guiche.chamar(senhas.getFilaSenhas());

            if (!sucesso)
            {
                MessageBox.Show("Não existem senhas aguardando atendimento.");
                return;
            }

            atualizarSenhas();
            atualizarAtendimentos();

            MessageBox.Show("Senha chamada com sucesso.");
        }

        private void atualizarSenhas()
        {
            lstSenhas.Items.Clear();

            foreach (Senha senha in senhas.getFilaSenhas())
            {
                lstSenhas.Items.Add(senha.dadosParciais());
            }
        }

        private void atualizarGuiches()
        {
            cmbGuiche.Items.Clear();

            foreach (Guiche guiche in guiches.getListaGuiches())
            {
                cmbGuiche.Items.Add(guiche.getId());
            }
        }

        private void atualizarAtendimentos()
        {
            lstAtendimentos.Items.Clear();

            foreach (Guiche guiche in guiches.getListaGuiches())
            {
                foreach (Senha senha in guiche.getAtendimentos())
                {
                    lstAtendimentos.Items.Add(
                        "Guichê " +
                        guiche.getId() +
                        " - " +
                        senha.dadosCompletos()
                    );
                }
            }
        }
    }
}
