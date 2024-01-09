namespace FazMad
{
    partial class FrmVenda
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
            tabPage1 = new TabPage();
            btnNovaVenda = new Button();
            btnPgtoVenda = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            label12 = new Label();
            label5 = new Label();
            txtNomeGado = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            rdbLeite = new RadioButton();
            rdbCorte = new RadioButton();
            groupBox2 = new GroupBox();
            txtVacaUd = new TextBox();
            btnSalvarVenda = new Button();
            label11 = new Label();
            lblTotPrec = new Label();
            label6 = new Label();
            lblTotVal = new Label();
            txtBezTotVal = new TextBox();
            a = new TextBox();
            txtNovTotVal = new TextBox();
            txtNovPrec = new TextBox();
            txtBoiTotVal = new TextBox();
            txtBoiPrec = new TextBox();
            txtVacaTotVal = new TextBox();
            txtVacaPrec = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnCancelarVenda = new Button();
            btnVerifcarVenda = new Button();
            lblTotPeso = new Label();
            lblTotUd = new Label();
            txtBezPes = new TextBox();
            txtBezUd = new TextBox();
            label4 = new Label();
            txtNovPes = new TextBox();
            txtNovUd = new TextBox();
            label3 = new Label();
            txtBoiPes = new TextBox();
            txtBoiUd = new TextBox();
            label2 = new Label();
            txtVacaPes = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            rdbUnidade = new RadioButton();
            rdbPeso = new RadioButton();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            btnPesqCompr = new Button();
            txtPesquisarComp = new TextBox();
            btnSalvarComprVenda = new Button();
            btbCancComprVenda = new Button();
            listView2 = new ListView();
            groupBox6 = new GroupBox();
            chbComprador = new CheckBox();
            txtCompVenda = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1472, 605);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNovaVenda);
            tabPage1.Controls.Add(btnPgtoVenda);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1464, 572);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.Location = new Point(9, 16);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(153, 36);
            btnNovaVenda.TabIndex = 17;
            btnNovaVenda.Text = "Nova Venda";
            btnNovaVenda.UseVisualStyleBackColor = true;
            // 
            // btnPgtoVenda
            // 
            btnPgtoVenda.Location = new Point(183, 16);
            btnPgtoVenda.Name = "btnPgtoVenda";
            btnPgtoVenda.Size = new Size(133, 36);
            btnPgtoVenda.TabIndex = 16;
            btnPgtoVenda.Text = "Pagamento";
            btnPgtoVenda.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Location = new Point(3, 71);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(421, 495);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(txtNomeGado);
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Location = new Point(9, 107);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(406, 90);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 24);
            label12.Name = "label12";
            label12.Size = new Size(83, 25);
            label12.TabIndex = 28;
            label12.Text = "Comprador";
            label12.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 23);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 8;
            label5.Text = "Dia da Venda";
            // 
            // txtNomeGado
            // 
            txtNomeGado.Location = new Point(10, 50);
            txtNomeGado.Name = "txtNomeGado";
            txtNomeGado.Size = new Size(216, 27);
            txtNomeGado.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(249, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(133, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbLeite);
            groupBox1.Controls.Add(rdbCorte);
            groupBox1.Location = new Point(6, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 75);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo do Gado";
            // 
            // rdbLeite
            // 
            rdbLeite.AutoSize = true;
            rdbLeite.Location = new Point(116, 35);
            rdbLeite.Name = "rdbLeite";
            rdbLeite.Size = new Size(59, 24);
            rdbLeite.TabIndex = 1;
            rdbLeite.TabStop = true;
            rdbLeite.Text = "Leite";
            rdbLeite.UseVisualStyleBackColor = true;
            // 
            // rdbCorte
            // 
            rdbCorte.AutoSize = true;
            rdbCorte.Location = new Point(24, 35);
            rdbCorte.Name = "rdbCorte";
            rdbCorte.Size = new Size(63, 24);
            rdbCorte.TabIndex = 0;
            rdbCorte.TabStop = true;
            rdbCorte.Text = "Corte";
            rdbCorte.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtVacaUd);
            groupBox2.Controls.Add(btnSalvarVenda);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(lblTotPrec);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblTotVal);
            groupBox2.Controls.Add(txtBezTotVal);
            groupBox2.Controls.Add(a);
            groupBox2.Controls.Add(txtNovTotVal);
            groupBox2.Controls.Add(txtNovPrec);
            groupBox2.Controls.Add(txtBoiTotVal);
            groupBox2.Controls.Add(txtBoiPrec);
            groupBox2.Controls.Add(txtVacaTotVal);
            groupBox2.Controls.Add(txtVacaPrec);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnCancelarVenda);
            groupBox2.Controls.Add(btnVerifcarVenda);
            groupBox2.Controls.Add(lblTotPeso);
            groupBox2.Controls.Add(lblTotUd);
            groupBox2.Controls.Add(txtBezPes);
            groupBox2.Controls.Add(txtBezUd);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNovPes);
            groupBox2.Controls.Add(txtNovUd);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtBoiPes);
            groupBox2.Controls.Add(txtBoiUd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtVacaPes);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(9, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 292);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumo Venda";
            // 
            // txtVacaUd
            // 
            txtVacaUd.Location = new Point(75, 50);
            txtVacaUd.Name = "txtVacaUd";
            txtVacaUd.Size = new Size(50, 27);
            txtVacaUd.TabIndex = 30;
            // 
            // btnSalvarVenda
            // 
            btnSalvarVenda.Location = new Point(21, 250);
            btnSalvarVenda.Name = "btnSalvarVenda";
            btnSalvarVenda.Size = new Size(109, 36);
            btnSalvarVenda.TabIndex = 29;
            btnSalvarVenda.Text = "Salvar";
            btnSalvarVenda.UseVisualStyleBackColor = true;
            btnSalvarVenda.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(300, 23);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 28;
            label11.Text = "Valor Total";
            // 
            // lblTotPrec
            // 
            lblTotPrec.AutoSize = true;
            lblTotPrec.Location = new Point(205, 202);
            lblTotPrec.Name = "lblTotPrec";
            lblTotPrec.Size = new Size(40, 20);
            lblTotPrec.TabIndex = 28;
            lblTotPrec.Text = "Unid";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 23);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 27;
            label6.Text = "R$ / Kg";
            // 
            // lblTotVal
            // 
            lblTotVal.AutoSize = true;
            lblTotVal.Location = new Point(300, 202);
            lblTotVal.Name = "lblTotVal";
            lblTotVal.Size = new Size(50, 20);
            lblTotVal.TabIndex = 26;
            lblTotVal.Text = "label6";
            // 
            // txtBezTotVal
            // 
            txtBezTotVal.Location = new Point(300, 166);
            txtBezTotVal.Name = "txtBezTotVal";
            txtBezTotVal.Size = new Size(92, 27);
            txtBezTotVal.TabIndex = 25;
            // 
            // a
            // 
            a.Location = new Point(205, 166);
            a.Name = "a";
            a.Size = new Size(85, 27);
            a.TabIndex = 24;
            // 
            // txtNovTotVal
            // 
            txtNovTotVal.Location = new Point(300, 130);
            txtNovTotVal.Name = "txtNovTotVal";
            txtNovTotVal.Size = new Size(92, 27);
            txtNovTotVal.TabIndex = 23;
            // 
            // txtNovPrec
            // 
            txtNovPrec.Location = new Point(205, 130);
            txtNovPrec.Name = "txtNovPrec";
            txtNovPrec.Size = new Size(85, 27);
            txtNovPrec.TabIndex = 22;
            // 
            // txtBoiTotVal
            // 
            txtBoiTotVal.Location = new Point(300, 93);
            txtBoiTotVal.Name = "txtBoiTotVal";
            txtBoiTotVal.Size = new Size(92, 27);
            txtBoiTotVal.TabIndex = 21;
            // 
            // txtBoiPrec
            // 
            txtBoiPrec.Location = new Point(205, 93);
            txtBoiPrec.Name = "txtBoiPrec";
            txtBoiPrec.Size = new Size(85, 27);
            txtBoiPrec.TabIndex = 20;
            // 
            // txtVacaTotVal
            // 
            txtVacaTotVal.Location = new Point(296, 50);
            txtVacaTotVal.Name = "txtVacaTotVal";
            txtVacaTotVal.Size = new Size(92, 27);
            txtVacaTotVal.TabIndex = 19;
            // 
            // txtVacaPrec
            // 
            txtVacaPrec.Location = new Point(205, 50);
            txtVacaPrec.Name = "txtVacaPrec";
            txtVacaPrec.Size = new Size(85, 27);
            txtVacaPrec.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(144, 23);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 17;
            label8.Text = "Peso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 23);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 16;
            label7.Text = "Unid";
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.Location = new Point(300, 250);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(92, 36);
            btnCancelarVenda.TabIndex = 15;
            btnCancelarVenda.Text = "Cancelar";
            btnCancelarVenda.UseVisualStyleBackColor = true;
            // 
            // btnVerifcarVenda
            // 
            btnVerifcarVenda.Location = new Point(6, 250);
            btnVerifcarVenda.Name = "btnVerifcarVenda";
            btnVerifcarVenda.Size = new Size(109, 36);
            btnVerifcarVenda.TabIndex = 14;
            btnVerifcarVenda.Text = "Calcular Total";
            btnVerifcarVenda.UseVisualStyleBackColor = true;
            // 
            // lblTotPeso
            // 
            lblTotPeso.AutoSize = true;
            lblTotPeso.Location = new Point(131, 202);
            lblTotPeso.Name = "lblTotPeso";
            lblTotPeso.Size = new Size(50, 20);
            lblTotPeso.TabIndex = 13;
            lblTotPeso.Text = "label6";
            // 
            // lblTotUd
            // 
            lblTotUd.AutoSize = true;
            lblTotUd.Location = new Point(75, 202);
            lblTotUd.Name = "lblTotUd";
            lblTotUd.Size = new Size(34, 20);
            lblTotUd.TabIndex = 12;
            lblTotUd.Text = "lblT";
            // 
            // txtBezPes
            // 
            txtBezPes.Location = new Point(133, 166);
            txtBezPes.Name = "txtBezPes";
            txtBezPes.Size = new Size(66, 27);
            txtBezPes.TabIndex = 11;
            // 
            // txtBezUd
            // 
            txtBezUd.Location = new Point(75, 166);
            txtBezUd.Name = "txtBezUd";
            txtBezUd.Size = new Size(50, 27);
            txtBezUd.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 166);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Bezerro";
            // 
            // txtNovPes
            // 
            txtNovPes.Location = new Point(131, 130);
            txtNovPes.Name = "txtNovPes";
            txtNovPes.Size = new Size(68, 27);
            txtNovPes.TabIndex = 8;
            // 
            // txtNovUd
            // 
            txtNovUd.Location = new Point(75, 130);
            txtNovUd.Name = "txtNovUd";
            txtNovUd.Size = new Size(50, 27);
            txtNovUd.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 133);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Novilho";
            // 
            // txtBoiPes
            // 
            txtBoiPes.Location = new Point(131, 93);
            txtBoiPes.Name = "txtBoiPes";
            txtBoiPes.Size = new Size(68, 27);
            txtBoiPes.TabIndex = 5;
            // 
            // txtBoiUd
            // 
            txtBoiUd.Location = new Point(75, 93);
            txtBoiUd.Name = "txtBoiUd";
            txtBoiUd.Size = new Size(50, 27);
            txtBoiUd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 96);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 3;
            label2.Text = "Boi";
            // 
            // txtVacaPes
            // 
            txtVacaPes.Location = new Point(131, 50);
            txtVacaPes.Name = "txtVacaPes";
            txtVacaPes.Size = new Size(68, 27);
            txtVacaPes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Vaca";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbUnidade);
            groupBox3.Controls.Add(rdbPeso);
            groupBox3.Location = new Point(223, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(192, 75);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Venda por";
            // 
            // rdbUnidade
            // 
            rdbUnidade.AutoSize = true;
            rdbUnidade.Location = new Point(103, 35);
            rdbUnidade.Name = "rdbUnidade";
            rdbUnidade.Size = new Size(83, 24);
            rdbUnidade.TabIndex = 1;
            rdbUnidade.TabStop = true;
            rdbUnidade.Text = "Unidade";
            rdbUnidade.UseVisualStyleBackColor = true;
            // 
            // rdbPeso
            // 
            rdbPeso.AutoSize = true;
            rdbPeso.Location = new Point(19, 35);
            rdbPeso.Name = "rdbPeso";
            rdbPeso.Size = new Size(57, 24);
            rdbPeso.TabIndex = 0;
            rdbPeso.TabStop = true;
            rdbPeso.Text = "Peso";
            rdbPeso.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1464, 572);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Outras Vendas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnPesqCompr);
            tabPage3.Controls.Add(txtPesquisarComp);
            tabPage3.Controls.Add(btnSalvarComprVenda);
            tabPage3.Controls.Add(btbCancComprVenda);
            tabPage3.Controls.Add(listView2);
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1464, 572);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Comprador";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPesqCompr
            // 
            btnPesqCompr.Location = new Point(293, 44);
            btnPesqCompr.Name = "btnPesqCompr";
            btnPesqCompr.Size = new Size(38, 28);
            btnPesqCompr.TabIndex = 7;
            btnPesqCompr.Text = "Pes";
            btnPesqCompr.UseVisualStyleBackColor = true;
            // 
            // txtPesquisarComp
            // 
            txtPesquisarComp.Location = new Point(29, 44);
            txtPesquisarComp.Name = "txtPesquisarComp";
            txtPesquisarComp.Size = new Size(247, 27);
            txtPesquisarComp.TabIndex = 6;
            // 
            // btnSalvarComprVenda
            // 
            btnSalvarComprVenda.Location = new Point(20, 287);
            btnSalvarComprVenda.Name = "btnSalvarComprVenda";
            btnSalvarComprVenda.Size = new Size(96, 41);
            btnSalvarComprVenda.TabIndex = 5;
            btnSalvarComprVenda.Text = "Incluir";
            btnSalvarComprVenda.UseVisualStyleBackColor = true;
            // 
            // btbCancComprVenda
            // 
            btbCancComprVenda.Location = new Point(255, 287);
            btbCancComprVenda.Name = "btbCancComprVenda";
            btbCancComprVenda.Size = new Size(96, 41);
            btbCancComprVenda.TabIndex = 4;
            btbCancComprVenda.Text = "Cancelar";
            btbCancComprVenda.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.FullRowSelect = true;
            listView2.Location = new Point(377, 118);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(711, 415);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(chbComprador);
            groupBox6.Controls.Add(txtCompVenda);
            groupBox6.Location = new Point(20, 103);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(331, 135);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "  Comprador";
            // 
            // chbComprador
            // 
            chbComprador.AutoSize = true;
            chbComprador.Location = new Point(18, 81);
            chbComprador.Name = "chbComprador";
            chbComprador.Size = new Size(63, 24);
            chbComprador.TabIndex = 1;
            chbComprador.Text = "Ativo";
            chbComprador.UseVisualStyleBackColor = true;
            chbComprador.Visible = false;
            // 
            // txtCompVenda
            // 
            txtCompVenda.Location = new Point(18, 38);
            txtCompVenda.Name = "txtCompVenda";
            txtCompVenda.Size = new Size(293, 27);
            txtCompVenda.TabIndex = 0;
            // 
            // FrmVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 622);
            Controls.Add(tabControl1);
            Name = "FrmVenda";
            Text = "FrmVenda";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private RadioButton rdbLeite;
        private RadioButton rdbCorte;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private RadioButton rdbUnidade;
        private RadioButton rdbPeso;
        private Label lblTotPeso;
        private Label lblTotUd;
        private TextBox txtBezPes;
        private TextBox txtBezUd;
        private Label label4;
        private TextBox txtNovPes;
        private TextBox txtNovUd;
        private Label label3;
        private TextBox txtBoiPes;
        private TextBox txtBoiUd;
        private Label label2;
        private TextBox txtVacaPes;
        private TextBox textBox1;
        private Label label1;
        private Label label8;
        private Label label7;
        private Button btnCancelarVenda;
        private Button btnVerifcarVenda;
        private GroupBox groupBox4;
        private TabPage tabPage3;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private CheckBox chbComprador;
        private TextBox txtCompVenda;
        private ListView listView2;
        private Button btbCancComprVenda;
        private Button btnSalvarComprVenda;
        private Button btnPesqCompr;
        private TextBox txtPesquisarComp;
        private Button button4;
        private Button button3;
        private TextBox txtNomeGado;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label lblTotVal;
        private TextBox txtBezTotVal;
        private TextBox a;
        private TextBox txtNovTotVal;
        private TextBox txtNovPrec;
        private TextBox txtBoiTotVal;
        private TextBox txtBoiPrec;
        private TextBox txtVacaTotVal;
        private TextBox txtVacaPrec;
        private Label label11;
        private Label lblTotPrec;
        private Label label12;
        private Button btnSalvarVenda;
        private TextBox txtVacaUd;
        private Button btnNovaVenda;
        private Button btnPgtoVenda;
    }
}