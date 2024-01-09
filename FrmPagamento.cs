using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazMad
{
    public partial class FrmPagamento : Form
    {
        public FrmPagamento()
        {
            InitializeComponent();
        }
        public DateTime vDataPgt { get; set; }
        public String vTipoPgt { get; set; }
        public String vContaPgt { get; set; }
        public decimal vValorPgt { get; set; }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (VerificaPgto())

            {
                this.vDataPgt = dtpPagamento.Value;
                this.vValorPgt = Convert.ToDecimal(txtValor.Text);
                this.vContaPgt= cboContaCadastrada.Text;
                DialogResult = DialogResult.OK;
              //  MessageBox.Show("ok");
            }
        }

        private bool VerificaPgto()
        {
            bool verpgt = false;

            if (rdbDinheiro.Checked || rdbPix.Checked || rdbTransf.Checked)
            {
                verpgt = true;
            }
            else

            {
                MessageBox.Show("Marque a forma de Pagamento");
                rdbPix.Focus();
                return verpgt = false;
            }

            if (txtValor.Text.Length > 0)
            {
                verpgt = true;
            }
            else

            {
                MessageBox.Show("Defina o Valor do Pagamento");
                return verpgt = false;
            }

            if (!rdbDinheiro.Checked)
            {
                if (cboConta.Text != "")
                {
                    verpgt = true;
                }
                else

                {
                    cboConta.Focus();
                    MessageBox.Show("Escolha o Banco");
                    return verpgt = false;
                }

            }

            return verpgt;
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            lblContaBanco.Visible = false;
            cboConta.Visible = false;
            this.vTipoPgt = "Din";
        }

        private void rdbPix_CheckedChanged(object sender, EventArgs e)
        {
            lblContaBanco.Visible = true;
            cboConta.Visible = true;
            this.vTipoPgt = "Pix";
        }

        private void rdbTransf_CheckedChanged(object sender, EventArgs e)
        {
            lblContaBanco.Visible = true;
            cboConta.Visible = true;
            this.vTipoPgt = "Trans";
        }

        
    }

}