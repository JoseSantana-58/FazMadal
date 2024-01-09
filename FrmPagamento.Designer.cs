namespace FazMad
{
    partial class FrmPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tbpPagar = new TabPage();
            btnCancelarPgto = new Button();
            btnPagar = new Button();
            groupBox5 = new GroupBox();
            dtpPagamento = new DateTimePicker();
            label29 = new Label();
            cboConta = new ComboBox();
            txtValor = new TextBox();
            groupBox6 = new GroupBox();
            rdbTransf = new RadioButton();
            rdbPix = new RadioButton();
            rdbDinheiro = new RadioButton();
            lblContaBanco = new Label();
            label13 = new Label();
            groupBox4 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabPage2 = new TabPage();
            btnAdicionarConta = new Button();
            label2 = new Label();
            cboContaCadastrada = new ComboBox();
            txtContaCadastrada = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tbpPagar.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpPagar);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(581, 398);
            tabControl1.TabIndex = 4;
            // 
            // tbpPagar
            // 
            tbpPagar.Controls.Add(btnCancelarPgto);
            tbpPagar.Controls.Add(btnPagar);
            tbpPagar.Controls.Add(groupBox5);
            tbpPagar.Controls.Add(groupBox4);
            tbpPagar.Location = new Point(4, 29);
            tbpPagar.Name = "tbpPagar";
            tbpPagar.Padding = new Padding(3);
            tbpPagar.Size = new Size(573, 365);
            tbpPagar.TabIndex = 1;
            tbpPagar.Text = "Pagamento";
            // 
            // btnCancelarPgto
            // 
            btnCancelarPgto.DialogResult = DialogResult.Cancel;
            btnCancelarPgto.Location = new Point(440, 313);
            btnCancelarPgto.Name = "btnCancelarPgto";
            btnCancelarPgto.Size = new Size(75, 31);
            btnCancelarPgto.TabIndex = 5;
            btnCancelarPgto.Text = "Cancelar";
            btnCancelarPgto.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(68, 313);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 31);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtpPagamento);
            groupBox5.Controls.Add(label29);
            groupBox5.Controls.Add(cboConta);
            groupBox5.Controls.Add(txtValor);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Controls.Add(lblContaBanco);
            groupBox5.Controls.Add(label13);
            groupBox5.Location = new Point(24, 107);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(525, 183);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            // 
            // dtpPagamento
            // 
            dtpPagamento.Format = DateTimePickerFormat.Short;
            dtpPagamento.Location = new Point(44, 140);
            dtpPagamento.Name = "dtpPagamento";
            dtpPagamento.Size = new Size(142, 27);
            dtpPagamento.TabIndex = 7;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(44, 109);
            label29.Name = "label29";
            label29.Size = new Size(75, 20);
            label29.TabIndex = 8;
            label29.Text = "Data Pgto";
            // 
            // cboConta
            // 
            cboConta.FormattingEnabled = true;
            cboConta.Items.AddRange(new object[] { "Brasil", "Santander", "ZeAntonio" });
            cboConta.Location = new Point(359, 139);
            cboConta.Name = "cboConta";
            cboConta.Size = new Size(121, 28);
            cboConta.TabIndex = 6;
            cboConta.Visible = false;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(217, 139);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(113, 27);
            txtValor.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdbTransf);
            groupBox6.Controls.Add(rdbPix);
            groupBox6.Controls.Add(rdbDinheiro);
            groupBox6.Location = new Point(44, 26);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(415, 69);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Meio de Pgto";
            // 
            // rdbTransf
            // 
            rdbTransf.AutoSize = true;
            rdbTransf.Location = new Point(279, 22);
            rdbTransf.Name = "rdbTransf";
            rdbTransf.Size = new Size(114, 24);
            rdbTransf.TabIndex = 2;
            rdbTransf.TabStop = true;
            rdbTransf.Text = "Transferencia";
            rdbTransf.UseVisualStyleBackColor = true;
            rdbTransf.CheckedChanged += rdbTransf_CheckedChanged;
            // 
            // rdbPix
            // 
            rdbPix.AutoSize = true;
            rdbPix.Location = new Point(150, 22);
            rdbPix.Name = "rdbPix";
            rdbPix.Size = new Size(46, 24);
            rdbPix.TabIndex = 1;
            rdbPix.TabStop = true;
            rdbPix.Text = "Pix";
            rdbPix.UseVisualStyleBackColor = true;
            rdbPix.CheckedChanged += rdbPix_CheckedChanged;
            // 
            // rdbDinheiro
            // 
            rdbDinheiro.AutoSize = true;
            rdbDinheiro.Location = new Point(18, 26);
            rdbDinheiro.Name = "rdbDinheiro";
            rdbDinheiro.Size = new Size(84, 24);
            rdbDinheiro.TabIndex = 0;
            rdbDinheiro.TabStop = true;
            rdbDinheiro.Text = "Dinheiro";
            rdbDinheiro.UseVisualStyleBackColor = true;
            rdbDinheiro.CheckedChanged += rdbDinheiro_CheckedChanged;
            // 
            // lblContaBanco
            // 
            lblContaBanco.AutoSize = true;
            lblContaBanco.Location = new Point(359, 109);
            lblContaBanco.Name = "lblContaBanco";
            lblContaBanco.Size = new Size(48, 20);
            lblContaBanco.TabIndex = 4;
            lblContaBanco.Text = "Conta";
            lblContaBanco.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(217, 109);
            label13.Name = "label13";
            label13.Size = new Size(43, 20);
            label13.TabIndex = 2;
            label13.Text = "Valor";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(25, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(525, 100);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 67);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 3;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 67);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 2;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(374, 23);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 1;
            label9.Text = "Nome";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 23);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 0;
            label10.Text = "IdVenda";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(167, 23);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 1;
            label11.Text = "Item";
            label11.Visible = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.Controls.Add(btnAdicionarConta);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(cboContaCadastrada);
            tabPage2.Controls.Add(txtContaCadastrada);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(573, 365);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Conta";
            // 
            // btnAdicionarConta
            // 
            btnAdicionarConta.Location = new Point(22, 118);
            btnAdicionarConta.Name = "btnAdicionarConta";
            btnAdicionarConta.Size = new Size(100, 31);
            btnAdicionarConta.TabIndex = 9;
            btnAdicionarConta.Text = "Adicionar conta";
            btnAdicionarConta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 37);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 8;
            label2.Text = "Contas Cadastradas";
            // 
            // cboContaCadastrada
            // 
            cboContaCadastrada.FormattingEnabled = true;
            cboContaCadastrada.Location = new Point(349, 60);
            cboContaCadastrada.Name = "cboContaCadastrada";
            cboContaCadastrada.Size = new Size(189, 28);
            cboContaCadastrada.TabIndex = 7;
            // 
            // txtContaCadastrada
            // 
            txtContaCadastrada.Location = new Point(22, 60);
            txtContaCadastrada.Name = "txtContaCadastrada";
            txtContaCadastrada.Size = new Size(241, 27);
            txtContaCadastrada.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 4;
            label1.Text = "Conta";
            // 
            // FrmPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 423);
            Controls.Add(tabControl1);
            Name = "FrmPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPagamento";
            tabControl1.ResumeLayout(false);
            tbpPagar.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblConta;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private Button btnPagar;
        private Button btnCancelar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tbpPagar;
        private GroupBox groupBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnCancelarPgto;
      
        private GroupBox groupBox5;
        private TextBox txtValor;
        private GroupBox groupBox6;
        private RadioButton rdbTransf;
        private RadioButton rdbPix;
        private RadioButton rdbDinheiro;
        private Label lblContaBanco;
        private Label label13;
        private TabPage tabPage2;
        private ComboBox cboConta;
        private Label label1;
        private TextBox txtContaCadastrada;
        private ComboBox cboContaCadastrada;
        private Button btnAdicionarConta;
        private DateTimePicker dtpPagamento;
        private Label label29;
    }
}