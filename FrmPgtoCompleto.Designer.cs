namespace FazMad
{
    partial class FrmPgtoCompleto
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
            btnCancelarPgto = new Button();
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
            btnPagar = new Button();
            groupBox4 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            rdbBoleto = new RadioButton();
            rdbCredito = new RadioButton();
            rdbCheque = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelarPgto
            // 
            btnCancelarPgto.DialogResult = DialogResult.Cancel;
            btnCancelarPgto.Location = new Point(704, 407);
            btnCancelarPgto.Name = "btnCancelarPgto";
            btnCancelarPgto.Size = new Size(75, 31);
            btnCancelarPgto.TabIndex = 14;
            btnCancelarPgto.Text = "Cancelar";
            btnCancelarPgto.UseVisualStyleBackColor = true;
            btnCancelarPgto.Click += btnCancelarPgto_Click;
            // 
            // dtpPagamento
            // 
            dtpPagamento.Format = DateTimePickerFormat.Short;
            dtpPagamento.Location = new Point(161, 392);
            dtpPagamento.Name = "dtpPagamento";
            dtpPagamento.Size = new Size(142, 27);
            dtpPagamento.TabIndex = 17;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(161, 368);
            label29.Name = "label29";
            label29.Size = new Size(75, 20);
            label29.TabIndex = 18;
            label29.Text = "Data Pgto";
            // 
            // cboConta
            // 
            cboConta.FormattingEnabled = true;
            cboConta.Items.AddRange(new object[] { "Brasil", "Santander", "ZeAntonio" });
            cboConta.Location = new Point(20, 391);
            cboConta.Name = "cboConta";
            cboConta.Size = new Size(121, 28);
            cboConta.TabIndex = 16;
            cboConta.Visible = false;
            cboConta.SelectedIndexChanged += cboConta_SelectedIndexChanged;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(30, 327);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(51, 27);
            txtValor.TabIndex = 10;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdbCheque);
            groupBox6.Controls.Add(rdbBoleto);
            groupBox6.Controls.Add(rdbCredito);
            groupBox6.Controls.Add(rdbTransf);
            groupBox6.Controls.Add(rdbPix);
            groupBox6.Controls.Add(rdbDinheiro);
            groupBox6.Location = new Point(12, 157);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(424, 135);
            groupBox6.TabIndex = 15;
            groupBox6.TabStop = false;
            groupBox6.Text = "Meio de Pgto";
            groupBox6.Enter += groupBox6_Enter;
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
            rdbPix.Location = new Point(149, 26);
            rdbPix.Name = "rdbPix";
            rdbPix.Size = new Size(46, 24);
            rdbPix.TabIndex = 1;
            rdbPix.TabStop = true;
            rdbPix.Text = "Pix";
            rdbPix.UseVisualStyleBackColor = true;
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
            // 
            // lblContaBanco
            // 
            lblContaBanco.AutoSize = true;
            lblContaBanco.Location = new Point(20, 363);
            lblContaBanco.Name = "lblContaBanco";
            lblContaBanco.Size = new Size(48, 20);
            lblContaBanco.TabIndex = 12;
            lblContaBanco.Text = "Conta";
            lblContaBanco.Visible = false;
            lblContaBanco.Click += lblContaBanco_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 304);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 11;
            label13.Text = "Nº Parc";
            label13.Click += label13_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(605, 407);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 31);
            btnPagar.TabIndex = 13;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(776, 100);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Enter += groupBox4_Enter;
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
            label10.Click += label10_Click;
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
            // rdbBoleto
            // 
            rdbBoleto.AutoSize = true;
            rdbBoleto.Location = new Point(149, 67);
            rdbBoleto.Name = "rdbBoleto";
            rdbBoleto.Size = new Size(71, 24);
            rdbBoleto.TabIndex = 4;
            rdbBoleto.TabStop = true;
            rdbBoleto.Text = "Boleto";
            rdbBoleto.UseVisualStyleBackColor = false;
            rdbBoleto.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Location = new Point(18, 67);
            rdbCredito.Name = "rdbCredito";
            rdbCredito.Size = new Size(76, 24);
            rdbCredito.TabIndex = 3;
            rdbCredito.TabStop = true;
            rdbCredito.Text = "Credito";
            rdbCredito.UseVisualStyleBackColor = true;
            // 
            // rdbCheque
            // 
            rdbCheque.AutoSize = true;
            rdbCheque.Location = new Point(279, 67);
            rdbCheque.Name = "rdbCheque";
            rdbCheque.Size = new Size(77, 24);
            rdbCheque.TabIndex = 5;
            rdbCheque.TabStop = true;
            rdbCheque.Text = "Cheque";
            rdbCheque.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 327);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 27);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 304);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 20;
            label1.Text = "Intervalo(mes)";
            
            // 
            // FrmPgtoCompleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelarPgto);
            Controls.Add(dtpPagamento);
            Controls.Add(label29);
            Controls.Add(cboConta);
            Controls.Add(txtValor);
            Controls.Add(groupBox6);
            Controls.Add(lblContaBanco);
            Controls.Add(label13);
            Controls.Add(btnPagar);
            Controls.Add(groupBox4);
            Name = "FrmPgtoCompleto";
            Text = "FrmPgtoCompleto";
            Load += FrmPgtoCompleto_Load;
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarPgto;
        private DateTimePicker dtpPagamento;
        private Label label29;
        private ComboBox cboConta;
        private TextBox txtValor;
        private GroupBox groupBox6;
        private RadioButton rdbTransf;
        private RadioButton rdbPix;
        private RadioButton rdbDinheiro;
        private Label lblContaBanco;
        private Label label13;
        private Button btnPagar;
        private GroupBox groupBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private RadioButton rdbBoleto;
        private RadioButton rdbCredito;
        private RadioButton rdbCheque;
        private TextBox textBox1;
        private Label label1;
    }
}