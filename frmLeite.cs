using AcessoAdados;
using Neg;
using System;
using System.CodeDom;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace FazMad
{
    public partial class frmLeite : Form
    {
        public frmLeite()
        {
            InitializeComponent();
            /*
            Conta conta = new Conta();
            conta.CriarTabela();
            
           Venda venda = new Venda();
              venda.CriarTabela();
            */
            cboSitConta.SelectedIndex = 0;

        }

        List<Ibase> leites = new List<Ibase>();
        List<Ibase> vendas = new List<Ibase>();
        List<Ibase> contas = new List<Ibase>();
        List<Ibase> compradores = new List<Ibase>();
        private Leite leite = new Leite();
        private void btnGrava_Click(object sender, EventArgs e)
        {
            leite.DataProd = dateTimePicker1.Value;
            leite.ProdManha = Convert.ToInt32(txtProdManha.Text);
            leite.ProdTarde = 0;
            leite.Preco = Convert.ToDecimal(txtPrecoLitro.Text);



            try
            {
                String? retorno = leite.Persistir("uspLeiteInserir").ToString();

                int verifica = Convert.ToInt32(retorno);

                MessageBox.Show(" Item numero  " + verifica + "   Inserido com sucesso");
                txtProdManha.Text = "";
                ListaProd();
            }
            catch (ErroCriado ErrCriado)
            {
                MessageBox.Show(ErrCriado.Message);
                txtProdManha.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtProdManha.Text = "";
            }




        }


        private void frmLeite_Load(object sender, EventArgs e)
        {

            ListaProd();
            ListaComprador();
            ProducaoDia();
            PopulaCboComprador();
            ListaVenda();
            ListaConta();
            ListaPag();

        }

        private void ListaProd()
        {
            if (chbAno.Checked)
            {
                leite.mes = 0;
            }
            else
            {
                leite.mes = dateTimePicker1.Value.Month;
            }

            leite.ano = dateTimePicker1.Value.Year;



            leites = leite.Consulta("uspLeiteProdListar");



            int totalProdManha = 0;
            int totalProdTarde = 0;
            int totalProdDia = 0;
            decimal ValorProd = 0;

            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Data", 130);
            listView1.Columns.Add("Prod Manha", 110);
            listView1.Columns.Add("Prod Tarde", 110);
            listView1.Columns.Add("Prod Dia", 110);
            listView1.Columns.Add("Preço", 90);
            listView1.Columns.Add("Total", 90);

            foreach (Leite leite in leites)
            {
                ListViewItem lvItem = new ListViewItem(leite.IdLeite.ToString());
                int ttotal = leite.ProdManha + leite.ProdTarde;
                lvItem.SubItems.Add(leite.DataProd.ToShortDateString());
                lvItem.SubItems.Add(leite.ProdManha.ToString());
                lvItem.SubItems.Add(leite.ProdTarde.ToString());
                lvItem.SubItems.Add((leite.ProdManha + leite.ProdTarde).ToString());
                lvItem.SubItems.Add(leite.Preco.ToString());
                lvItem.SubItems.Add((leite.Preco * ttotal).ToString());
                decimal precolitro = leite.Preco;
                listView1.Items.Add(lvItem);

                txtPrecoLitro.Text = precolitro.ToString();
                totalProdManha = totalProdManha + leite.ProdManha;
                totalProdTarde = totalProdTarde + leite.ProdTarde;
                totalProdDia += leite.ProdManha + leite.ProdTarde;
                ValorProd += leite.Preco * ttotal;

            }

            lblManha.Text = totalProdManha.ToString();
            lblTarde.Text = totalProdTarde.ToString();
            lblProdDia.Text = totalProdDia.ToString();
            lblValor.Text = decimal.Round(ValorProd, 2).ToString();
            if (totalProdDia > 0)
            {
                lblPreco.Text = decimal.Round((ValorProd / totalProdDia), 2).ToString();
            }
            else
            {
                lblPreco.Text = "0";
            }
        }

        private void ListaComprador()
        {
            Comprador comprador = new Comprador();
            comprador.Grupo = 1;




            compradores = comprador.Consulta("uspCompradorListar");


            listView2.Clear();
            listView2.View = View.Details;
            listView2.Columns.Add("ID", 40);
            listView2.Columns.Add("Grupo", 70);
            listView2.Columns.Add("Nome", 160);
            listView2.Columns.Add("Ativo", 160);

            foreach (Comprador compr in compradores)
            {
                ListViewItem lvItem = new ListViewItem(compr.IdComp.ToString());
                lvItem.SubItems.Add(compr.Grupo.ToString());
                lvItem.SubItems.Add(compr.Nome.ToString());
                lvItem.SubItems.Add(compr.Padrao.ToString());
                listView2.Items.Add(lvItem);


            }

        }

        private void PopulaCboComprador()
        {
            cboComprador.Items.Clear();

            List<object> lcbo = new List<object>();

            foreach (Comprador compr in compradores)
            {
                lcbo.Add(compr);

            }
            cboCompradorConta.DataSource = cboComprador.DataSource = null;
            cboCompradorConta.DataSource = cboComprador.DataSource = lcbo;
            cboCompradorConta.DisplayMember = cboComprador.DisplayMember = "Nome";
            cboCompradorConta.ValueMember = cboComprador.ValueMember = "IdComp";
        }
        private void btnSalvarComprador_Click(object sender, EventArgs e)
        {
            Comprador comprador = new Comprador();
            comprador.Grupo = 1;

            if (txtComprador.Text.Length > 0)
            {
                comprador.Nome = txtComprador.Text;
                comprador.Padrao = "Sim";
                comprador.Persistir("uspCompradorInserir");
                ListaComprador();
            }
            else
            {

                MessageBox.Show("Defina o Nome do Comprador");
                txtComprador.Focus();

            }
        }

        private void btbCancComprador_Click(object sender, EventArgs e)
        {
            txtComprador.Text = string.Empty;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblMesProd.Text = dateTimePicker1.Value.ToString("MMMM");
            if (dateTimePicker1.Value.Month != DateTime.Today.Month)
            {

                listView1.Items.Clear();
            }
        }

        private void btnListarProd_Click(object sender, EventArgs e)
        {
            ListaProd();
        }

        private void ProducaoDia()
        {
            foreach (Leite leite in leites)
            {
                if (leite != null && leite.DataProd.ToShortDateString() == dateTimePicker2.Value.ToShortDateString())
                {
                    txtProdVenda.Text = (leite.ProdManha + leite.ProdTarde).ToString();
                    txtPrecVenda.Text = leite.Preco.ToString();
                    txtComprador.Text = leite.ProdManha.ToString();
                    TxtLitVenda.Text = txtProdVenda.Text;
                    txtPerda.Text = (leite.ProdManha + leite.ProdTarde - Convert.ToUInt32(TxtLitVenda.Text)).ToString();
                    txtNumVenda.Text = "1";

                }
            }

        }



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            ProducaoDia();
            ListaVenda();

        }

        private void btnGravaVenda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();

            try
            {
                if (VerificaVenda())
                {
                    venda.DataVend = dateTimePicker2.Value;
                    venda.Quantidade = Convert.ToInt32(TxtLitVenda.Text);
                    venda.IdComprador = (int)cboComprador.SelectedValue;
                    venda.PrecoVenda = Convert.ToDecimal(txtPrecVenda.Text);
                    venda.NumVenda = Convert.ToInt32(txtNumVenda.Text);
                    venda.Perda = Convert.ToInt32(txtPerda.Text);
                    // venda.NumItemPag = 0;
                    // venda.DataPag = Convert.ToDateTime("1980-01-01");
                    // venda.NumPag = 0;


                    venda.Persistir("uspLeiteVendaInserir");
                    ListaVenda();
                    TxtLitVenda.Text = "";
                    txtProdVenda.Text = "";
                }
            }
            catch (ErroCriado ErrCriado)
            {
                MessageBox.Show(ErrCriado.Message);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private bool VerificaVenda()
        {
            bool VendaOk;
            if (txtProdVenda.Text == "")
            {
                MessageBox.Show("Produção não Cadastrada pra este Dia ");
                VendaOk = false;
                txtProdVenda.Focus();

            }
            else if (TxtLitVenda.Text == "" || Convert.ToInt32(TxtLitVenda.Text) > Convert.ToInt32(txtProdVenda.Text))
            {
                MessageBox.Show(" Verifique a Quantidade");
                VendaOk = false;
                TxtLitVenda.Focus();

            }
            else if (cboComprador.Text == "")
            {
                MessageBox.Show(" Verifique a Comprador");
                VendaOk = false;
                cboComprador.Focus();

            }
            else if (txtPrecVenda.Text == "" || txtPrecVenda.Text.Trim() != txtPrecoLitro.Text.Trim())
            {
                MessageBox.Show(" Verifique o Preço");
                VendaOk = false;
                TxtLitVenda.Focus();

            }
            else if (Convert.ToInt32(TxtLitVenda.Text) < Convert.ToInt32(txtProdVenda.Text))
            {
                txtPerda.Text = (-(Convert.ToInt32(TxtLitVenda.Text) - Convert.ToInt32(txtProdVenda.Text))).ToString();
                VendaOk = true;

            }
            else if (txtProdVenda.Text.Length == 0)
            {
                MessageBox.Show("Ainda não tem produção deste dia cadastrada");
                VendaOk = false;
                TxtLitVenda.Focus();


            }

            else
            { VendaOk = true; }

            return VendaOk;
        }

        private void ListaVenda()
        {
            Venda venda = new Venda();
            if (rdbDia.Checked)
                venda.Periodo = 1;

            if (rdmSemana.Checked)
                venda.Periodo = 2;

            if (rdmMes.Checked)
                venda.Periodo = 3;

            if (rdbAno.Checked)
                venda.Periodo = 4;


            venda.DataVend = dateTimePicker2.Value;

            vendas = venda.Consulta("uspLeiteVendaListar");


            int totalProdVend = 0;
            Decimal ValorVenda = 0;
            int totalPerda = 0;

            listView3.Clear();
            listView3.View = View.Details;
            listView3.Columns.Add("ID", 40);
            listView3.Columns.Add("Data", 90);
            listView3.Columns.Add("Comprador", 130);
            listView3.Columns.Add("Litros", 70);
            listView3.Columns.Add("Preco", 70);
            listView3.Columns.Add("Total", 70);
            listView3.Columns.Add("Situacao", 75);
            listView3.Columns.Add("Perda", 60);
            listView3.Columns.Add("Hora Cadastro", 160);

            foreach (Venda venda1 in vendas)
            {


                ListViewItem lvItem = new ListViewItem(venda1.IdVenda.ToString());

                lvItem.SubItems.Add(venda1.DataVend.ToShortDateString());
                lvItem.SubItems.Add(venda1.Nome.ToString());
                lvItem.SubItems.Add(venda1.Quantidade.ToString());
                lvItem.SubItems.Add(venda1.PrecoVenda.ToString());
                lvItem.SubItems.Add((venda1.Quantidade * venda1.PrecoVenda).ToString());
                lvItem.SubItems.Add(venda1.SitVenda.ToString());
                lvItem.SubItems.Add(venda1.Perda.ToString());
                lvItem.SubItems.Add(venda1.horatransa.ToString());

                listView3.Items.Add(lvItem);


                totalProdVend = totalProdVend + venda1.Quantidade;
                ValorVenda = ValorVenda + venda1.Quantidade * venda1.PrecoVenda;
                totalPerda = totalPerda + venda1.Perda;


            }

            lblQuantidade.Text = totalProdVend.ToString();
            lblTotalVenda.Text = Decimal.Round(ValorVenda, 2).ToString();
            if (totalProdVend > 0)
            {
                lblPrecoVenda.Text = Decimal.Round((ValorVenda / totalProdVend), 2).ToString();
            }
            else
            {
                lblPrecoVenda.Text = "0";
            }
            lblTotalPerda.Text = totalPerda.ToString();
        }

        private void rdbDia_Click(object sender, EventArgs e)
        {
            ListaVenda();
        }

        private void rdmSemana_Click(object sender, EventArgs e)
        {
            ListaVenda();
        }

        private void rdmMes_CheckedChanged(object sender, EventArgs e)
        {
            ListaVenda();
        }

        private void rdbAno_CheckedChanged(object sender, EventArgs e)
        {
            ListaVenda();
        }



        private void btnIncluirPgto_Click(object sender, EventArgs e)
        {
            FrmPagamento frmPagamento = new FrmPagamento();


            DialogResult resultado = frmPagamento.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Conta conta = new Conta();

                conta.DataPag = frmPagamento.vDataPgt;
                conta.TipoPag = frmPagamento.vTipoPgt;
                conta.ValorPag = frmPagamento.vValorPgt;
                conta.ContaPag = frmPagamento.vContaPgt;
                conta.IdComprador = (int)cboCompradorConta.SelectedValue;

                conta.Persistir("uspLeitePagamentoInserir");


                frmPagamento.Close();
                frmPagamento.Dispose();
                ListaConta();
                ListaPag();
            }

        }

        private void cboCompradorConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListaConta()
        {
            Venda venda = new Venda();

            venda.SitVenda = cboSitConta.Text.Trim() + "%";
            venda.IdComprador = (int)cboCompradorConta.SelectedValue;
            vendas = venda.Consulta("uspLeiteContaListar");

            int totalProdVend = 0;
            Decimal ValorVenda = 0;
            int totalPerda = 0;

            listView7.Clear();
            listView7.View = View.Details;
            listView7.Columns.Add("IT", 40);
            listView7.Columns.Add("Data", 90);
            listView7.Columns.Add("Valor", 70);
            listView7.Columns.Add("Situacao", 75);
            listView7.Columns.Add("Saldo", 80);
            listView7.Columns.Add("IdComp", 60);
            listView7.Columns.Add("Data Pgto", 90);
            // listView3.Columns.Add("Hora Cadastro", 160);
            int lin = 1;
            foreach (Venda venda2 in vendas)
            {


                ListViewItem lvItem = new ListViewItem(Convert.ToString(lin));

                lvItem.SubItems.Add(venda2.DataVend.ToShortDateString());
                lvItem.SubItems.Add((venda2.Quantidade * venda2.PrecoVenda).ToString());
                lvItem.SubItems.Add(venda2.SitVenda.ToString());
                lvItem.SubItems.Add(venda2.Saldo.ToString());
                lvItem.SubItems.Add(venda2.IdComprador.ToString());
                lvItem.SubItems.Add(venda2.DataPag.ToString());

                listView7.Items.Add(lvItem);


                // totalProdVend = totalProdVend + venda1.Quantidade;
                // ValorVenda = ValorVenda + venda1.Quantidade * venda1.PrecoVenda;
                // totalPerda = totalPerda + venda1.Perda;
                lin += 1;

            }
            /*
            lblQuantidade.Text = totalProdVend.ToString();
            lblTotalVenda.Text = Decimal.Round(ValorVenda, 2).ToString();
            if (totalProdVend > 0)
            {
                lblPrecoVenda.Text = Decimal.Round((ValorVenda / totalProdVend), 2).ToString();
            }
            else
            {
                lblPrecoVenda.Text = "0";
            }
            lblTotalPerda.Text = totalPerda.ToSt
            */
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage4")
            {
                ListaConta();
                ListaPag();
            }

        }

        private void cboSitConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage4")
            { ListaConta(); }
        }

        private void cboCompradorConta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage4")
            {
                ListaConta();
                ListaPag();
            }
        }

        private void ListaPag()
        {
            Conta conta = new Conta();

            conta.IdComprador = (int)cboCompradorConta.SelectedValue;

            contas = conta.Consulta("uspLeitePagamentoListar");




            listView6.Clear();
            listView6.View = View.Details;
            listView6.Columns.Add("ID", 40);
            listView6.Columns.Add("Data", 90);
            listView6.Columns.Add("Valor", 80);
            listView6.Columns.Add("Num Pgt", 70);
            listView6.Columns.Add("No Dias", 75);
            listView6.Columns.Add("TipoPgt", 70);
            listView6.Columns.Add("Conta", 75);
            listView6.Columns.Add("IdComp", 60);
            listView6.Columns.Add("Hora Cadastro", 160);

            foreach (Conta conta1 in contas)
            {


                ListViewItem lvItem = new ListViewItem(conta1.IdPag.ToString());

                lvItem.SubItems.Add(conta1.DataPag.ToShortDateString());
                lvItem.SubItems.Add(conta1.ValorPag.ToString());
                lvItem.SubItems.Add(conta1.NumPag.ToString());
                lvItem.SubItems.Add(conta1.NumItemPag.ToString());
                lvItem.SubItems.Add(conta1.TipoPag.ToString());
                lvItem.SubItems.Add(conta1.ContaPag.ToString());
                lvItem.SubItems.Add(conta1.IdComprador.ToString());
                lvItem.SubItems.Add(conta1.horatransa.ToString());

                listView6.Items.Add(lvItem);



            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }

}
