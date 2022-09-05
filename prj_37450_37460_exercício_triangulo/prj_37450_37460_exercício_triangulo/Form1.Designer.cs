namespace prj_37450_37460_exercício_triangulo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.Escolha = new System.Windows.Forms.GroupBox();
            this.cmbtp = new System.Windows.Forms.ComboBox();
            this.rbar = new System.Windows.Forms.RadioButton();
            this.rbtipot = new System.Windows.Forms.RadioButton();
            this.gbtp = new System.Windows.Forms.GroupBox();
            this.txtresul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtz = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.txtx = new System.Windows.Forms.TextBox();
            this.btnlimparl = new System.Windows.Forms.Button();
            this.btncalculadora = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rctxtresp = new System.Windows.Forms.RichTextBox();
            this.gbrar = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Área = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.crbhab = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.Escolha.SuspendLayout();
            this.gbtp.SuspendLayout();
            this.gbrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbImagem
            // 
            this.pcbImagem.BackgroundImage = global::prj_37450_37460_exercício_triangulo.Properties.Resources.triangulo;
            this.pcbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbImagem.Location = new System.Drawing.Point(432, 277);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(217, 165);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagem.TabIndex = 0;
            this.pcbImagem.TabStop = false;
            this.pcbImagem.Click += new System.EventHandler(this.pcbImagem_Click);
            // 
            // Escolha
            // 
            this.Escolha.Controls.Add(this.cmbtp);
            this.Escolha.Controls.Add(this.rbar);
            this.Escolha.Controls.Add(this.rbtipot);
            this.Escolha.Location = new System.Drawing.Point(3, 2);
            this.Escolha.Name = "Escolha";
            this.Escolha.Size = new System.Drawing.Size(450, 44);
            this.Escolha.TabIndex = 1;
            this.Escolha.TabStop = false;
            this.Escolha.Text = "Escolha";
            // 
            // cmbtp
            // 
            this.cmbtp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtp.FormattingEnabled = true;
            this.cmbtp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbtp.Items.AddRange(new object[] {
            "Tipo de Triângulo",
            "Área do Triângulo"});
            this.cmbtp.Location = new System.Drawing.Point(329, 15);
            this.cmbtp.Name = "cmbtp";
            this.cmbtp.Size = new System.Drawing.Size(110, 21);
            this.cmbtp.TabIndex = 2;
            this.cmbtp.SelectedIndexChanged += new System.EventHandler(this.cmbtp_SelectedIndexChanged);
            // 
            // rbar
            // 
            this.rbar.AutoSize = true;
            this.rbar.Location = new System.Drawing.Point(161, 21);
            this.rbar.Name = "rbar";
            this.rbar.Size = new System.Drawing.Size(109, 17);
            this.rbar.TabIndex = 1;
            this.rbar.TabStop = true;
            this.rbar.Text = "Área do Triângulo";
            this.rbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbar.UseVisualStyleBackColor = true;
            this.rbar.CheckedChanged += new System.EventHandler(this.rbar_CheckedChanged);
            // 
            // rbtipot
            // 
            this.rbtipot.AutoSize = true;
            this.rbtipot.Location = new System.Drawing.Point(16, 19);
            this.rbtipot.Name = "rbtipot";
            this.rbtipot.Size = new System.Drawing.Size(108, 17);
            this.rbtipot.TabIndex = 0;
            this.rbtipot.TabStop = true;
            this.rbtipot.Text = "Tipo de Triângulo";
            this.rbtipot.UseVisualStyleBackColor = true;
            this.rbtipot.CheckedChanged += new System.EventHandler(this.rbtipot_CheckedChanged);
            // 
            // gbtp
            // 
            this.gbtp.Controls.Add(this.txtresul);
            this.gbtp.Controls.Add(this.label4);
            this.gbtp.Controls.Add(this.label3);
            this.gbtp.Controls.Add(this.label2);
            this.gbtp.Controls.Add(this.label1);
            this.gbtp.Controls.Add(this.txtz);
            this.gbtp.Controls.Add(this.txty);
            this.gbtp.Controls.Add(this.txtx);
            this.gbtp.Location = new System.Drawing.Point(3, 52);
            this.gbtp.Name = "gbtp";
            this.gbtp.Size = new System.Drawing.Size(221, 174);
            this.gbtp.TabIndex = 2;
            this.gbtp.TabStop = false;
            this.gbtp.Text = "Tipo do Triângulo";
            this.gbtp.UseWaitCursor = true;
            // 
            // txtresul
            // 
            this.txtresul.Location = new System.Drawing.Point(16, 137);
            this.txtresul.Name = "txtresul";
            this.txtresul.ReadOnly = true;
            this.txtresul.Size = new System.Drawing.Size(183, 20);
            this.txtresul.TabIndex = 1000;
            this.txtresul.TabStop = false;
            this.txtresul.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.UseWaitCursor = true;
            // 
            // txtz
            // 
            this.txtz.Location = new System.Drawing.Point(172, 46);
            this.txtz.Name = "txtz";
            this.txtz.Size = new System.Drawing.Size(43, 20);
            this.txtz.TabIndex = 2;
            this.txtz.UseWaitCursor = true;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(94, 46);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(43, 20);
            this.txty.TabIndex = 1;
            this.txty.UseWaitCursor = true;
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(16, 46);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(43, 20);
            this.txtx.TabIndex = 0;
            this.txtx.UseWaitCursor = true;
            // 
            // btnlimparl
            // 
            this.btnlimparl.BackgroundImage = global::prj_37450_37460_exercício_triangulo.Properties.Resources.MicrosoftTeams_image;
            this.btnlimparl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimparl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimparl.ForeColor = System.Drawing.Color.Coral;
            this.btnlimparl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimparl.Location = new System.Drawing.Point(245, 223);
            this.btnlimparl.Name = "btnlimparl";
            this.btnlimparl.Size = new System.Drawing.Size(59, 47);
            this.btnlimparl.TabIndex = 5;
            this.btnlimparl.UseVisualStyleBackColor = true;
            // 
            // btncalculadora
            // 
            this.btncalculadora.BackgroundImage = global::prj_37450_37460_exercício_triangulo.Properties.Resources.MicrosoftTeams_image__1_;
            this.btncalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncalculadora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculadora.ForeColor = System.Drawing.Color.Coral;
            this.btncalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncalculadora.Location = new System.Drawing.Point(245, 84);
            this.btncalculadora.Name = "btncalculadora";
            this.btncalculadora.Size = new System.Drawing.Size(59, 47);
            this.btncalculadora.TabIndex = 6;
            this.btncalculadora.UseVisualStyleBackColor = true;
            this.btncalculadora.Click += new System.EventHandler(this.btncalculadora_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackgroundImage = global::prj_37450_37460_exercício_triangulo.Properties.Resources.MicrosoftTeams_image;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.Coral;
            this.btnlimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpar.Location = new System.Drawing.Point(245, 156);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(59, 47);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Limpar Lista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Limpar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Calculadora";
            // 
            // rctxtresp
            // 
            this.rctxtresp.Location = new System.Drawing.Point(12, 310);
            this.rctxtresp.Name = "rctxtresp";
            this.rctxtresp.ReadOnly = true;
            this.rctxtresp.Size = new System.Drawing.Size(398, 132);
            this.rctxtresp.TabIndex = 11;
            this.rctxtresp.TabStop = false;
            this.rctxtresp.Text = "";
            // 
            // gbrar
            // 
            this.gbrar.Controls.Add(this.label10);
            this.gbrar.Controls.Add(this.label9);
            this.gbrar.Controls.Add(this.Área);
            this.gbrar.Controls.Add(this.textBox3);
            this.gbrar.Controls.Add(this.txtaltura);
            this.gbrar.Controls.Add(this.txtbase);
            this.gbrar.Location = new System.Drawing.Point(414, 52);
            this.gbrar.Name = "gbrar";
            this.gbrar.Size = new System.Drawing.Size(215, 174);
            this.gbrar.TabIndex = 12;
            this.gbrar.TabStop = false;
            this.gbrar.Text = "Área do Triângulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Área";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "ALtura";
            // 
            // Área
            // 
            this.Área.AutoSize = true;
            this.Área.Location = new System.Drawing.Point(28, 35);
            this.Área.Name = "Área";
            this.Área.Size = new System.Drawing.Size(31, 13);
            this.Área.TabIndex = 3;
            this.Área.Text = "Base";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(45, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TabStop = false;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(84, 51);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(45, 20);
            this.txtaltura.TabIndex = 1;
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(18, 51);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(45, 20);
            this.txtbase.TabIndex = 0;
            this.txtbase.TextChanged += new System.EventHandler(this.txtbase_TextChanged);
            // 
            // crbhab
            // 
            this.crbhab.AutoSize = true;
            this.crbhab.Location = new System.Drawing.Point(56, 253);
            this.crbhab.Name = "crbhab";
            this.crbhab.Size = new System.Drawing.Size(122, 17);
            this.crbhab.TabIndex = 13;
            this.crbhab.Text = "Habilitar Lixeira Lista";
            this.crbhab.UseVisualStyleBackColor = true;
            this.crbhab.CheckedChanged += new System.EventHandler(this.crbhab_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 454);
            this.Controls.Add(this.crbhab);
            this.Controls.Add(this.gbrar);
            this.Controls.Add(this.rctxtresp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalculadora);
            this.Controls.Add(this.btnlimparl);
            this.Controls.Add(this.gbtp);
            this.Controls.Add(this.Escolha);
            this.Controls.Add(this.pcbImagem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora Triângulo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalculadoraTriângulo);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.Escolha.ResumeLayout(false);
            this.Escolha.PerformLayout();
            this.gbtp.ResumeLayout(false);
            this.gbtp.PerformLayout();
            this.gbrar.ResumeLayout(false);
            this.gbrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.GroupBox Escolha;
        private System.Windows.Forms.RadioButton rbar;
        private System.Windows.Forms.RadioButton rbtipot;
        private System.Windows.Forms.GroupBox gbtp;
        private System.Windows.Forms.TextBox txtresul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtz;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Button btnlimparl;
        private System.Windows.Forms.Button btncalculadora;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rctxtresp;
        private System.Windows.Forms.GroupBox gbrar;
        private System.Windows.Forms.ComboBox cmbtp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Área;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.CheckBox crbhab;
    }
}

