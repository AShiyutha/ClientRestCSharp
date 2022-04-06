
namespace ClienteRestCSharp
{
    partial class Form1
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
            this.btnNome = new System.Windows.Forms.Button();
            this.btnCapital = new System.Windows.Forms.Button();
            this.btnRegiao = new System.Windows.Forms.Button();
            this.btnSubReg = new System.Windows.Forms.Button();
            this.btnPopulacao = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnFuso = new System.Windows.Forms.Button();
            this.btnNomeNat = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBandeira = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtRegiao = new System.Windows.Forms.TextBox();
            this.txtSubReg = new System.Windows.Forms.TextBox();
            this.txtPopulacao = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtFuso = new System.Windows.Forms.TextBox();
            this.txtNomeNat = new System.Windows.Forms.TextBox();
            this.lstVPaises = new System.Windows.Forms.ListView();
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnRegiao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSubReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPopulacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnFuso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNomeNativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstBandeira = new System.Windows.Forms.ListBox();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.grbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(186, 24);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(82, 23);
            this.btnNome.TabIndex = 0;
            this.btnNome.Text = "Nome";
            this.btnNome.UseVisualStyleBackColor = true;
            // 
            // btnCapital
            // 
            this.btnCapital.Location = new System.Drawing.Point(186, 53);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(82, 23);
            this.btnCapital.TabIndex = 1;
            this.btnCapital.Text = "Capital";
            this.btnCapital.UseVisualStyleBackColor = true;
            // 
            // btnRegiao
            // 
            this.btnRegiao.Location = new System.Drawing.Point(186, 82);
            this.btnRegiao.Name = "btnRegiao";
            this.btnRegiao.Size = new System.Drawing.Size(82, 23);
            this.btnRegiao.TabIndex = 2;
            this.btnRegiao.Text = "Regiao";
            this.btnRegiao.UseVisualStyleBackColor = true;
            // 
            // btnSubReg
            // 
            this.btnSubReg.Location = new System.Drawing.Point(186, 111);
            this.btnSubReg.Name = "btnSubReg";
            this.btnSubReg.Size = new System.Drawing.Size(82, 23);
            this.btnSubReg.TabIndex = 3;
            this.btnSubReg.Text = "Sub-Regiao";
            this.btnSubReg.UseVisualStyleBackColor = true;
            // 
            // btnPopulacao
            // 
            this.btnPopulacao.Location = new System.Drawing.Point(186, 140);
            this.btnPopulacao.Name = "btnPopulacao";
            this.btnPopulacao.Size = new System.Drawing.Size(82, 23);
            this.btnPopulacao.TabIndex = 4;
            this.btnPopulacao.Text = "Populacao";
            this.btnPopulacao.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(186, 169);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(82, 23);
            this.btnArea.TabIndex = 5;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            // 
            // btnFuso
            // 
            this.btnFuso.Location = new System.Drawing.Point(186, 198);
            this.btnFuso.Name = "btnFuso";
            this.btnFuso.Size = new System.Drawing.Size(82, 23);
            this.btnFuso.TabIndex = 6;
            this.btnFuso.Text = "Fuso horario";
            this.btnFuso.UseVisualStyleBackColor = true;
            // 
            // btnNomeNat
            // 
            this.btnNomeNat.Location = new System.Drawing.Point(186, 227);
            this.btnNomeNat.Name = "btnNomeNat";
            this.btnNomeNat.Size = new System.Drawing.Size(82, 23);
            this.btnNomeNat.TabIndex = 7;
            this.btnNomeNat.Text = "Nome nativo";
            this.btnNomeNat.UseVisualStyleBackColor = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(12, 272);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(108, 23);
            this.btnTodos.TabIndex = 8;
            this.btnTodos.Text = "Todos Paises";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(193, 272);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnBandeira
            // 
            this.btnBandeira.Location = new System.Drawing.Point(713, 327);
            this.btnBandeira.Name = "btnBandeira";
            this.btnBandeira.Size = new System.Drawing.Size(75, 23);
            this.btnBandeira.TabIndex = 10;
            this.btnBandeira.Text = "Bandeira";
            this.btnBandeira.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(155, 20);
            this.txtNome.TabIndex = 11;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(13, 55);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(155, 20);
            this.txtCapital.TabIndex = 12;
            // 
            // txtRegiao
            // 
            this.txtRegiao.Location = new System.Drawing.Point(13, 84);
            this.txtRegiao.Name = "txtRegiao";
            this.txtRegiao.Size = new System.Drawing.Size(155, 20);
            this.txtRegiao.TabIndex = 13;
            // 
            // txtSubReg
            // 
            this.txtSubReg.Location = new System.Drawing.Point(13, 113);
            this.txtSubReg.Name = "txtSubReg";
            this.txtSubReg.Size = new System.Drawing.Size(155, 20);
            this.txtSubReg.TabIndex = 14;
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Location = new System.Drawing.Point(13, 142);
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(155, 20);
            this.txtPopulacao.TabIndex = 15;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(13, 171);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(155, 20);
            this.txtArea.TabIndex = 16;
            // 
            // txtFuso
            // 
            this.txtFuso.Location = new System.Drawing.Point(13, 200);
            this.txtFuso.Name = "txtFuso";
            this.txtFuso.Size = new System.Drawing.Size(155, 20);
            this.txtFuso.TabIndex = 17;
            // 
            // txtNomeNat
            // 
            this.txtNomeNat.Location = new System.Drawing.Point(13, 229);
            this.txtNomeNat.Name = "txtNomeNat";
            this.txtNomeNat.Size = new System.Drawing.Size(155, 20);
            this.txtNomeNat.TabIndex = 18;
            // 
            // lstVPaises
            // 
            this.lstVPaises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnNome,
            this.clnCapital,
            this.clnRegiao,
            this.clnSubReg,
            this.clnPopulacao,
            this.clnArea,
            this.clnFuso,
            this.clnNomeNativo});
            this.lstVPaises.HideSelection = false;
            this.lstVPaises.Location = new System.Drawing.Point(293, 24);
            this.lstVPaises.Name = "lstVPaises";
            this.lstVPaises.Size = new System.Drawing.Size(984, 297);
            this.lstVPaises.TabIndex = 19;
            this.lstVPaises.UseCompatibleStateImageBehavior = false;
            this.lstVPaises.View = System.Windows.Forms.View.Details;
            // 
            // clnNome
            // 
            this.clnNome.Text = "Nome";
            this.clnNome.Width = 134;
            // 
            // clnCapital
            // 
            this.clnCapital.Text = "Capital";
            this.clnCapital.Width = 138;
            // 
            // clnRegiao
            // 
            this.clnRegiao.Text = "Regiao";
            this.clnRegiao.Width = 125;
            // 
            // clnSubReg
            // 
            this.clnSubReg.Text = "Sub-Regiao";
            this.clnSubReg.Width = 140;
            // 
            // clnPopulacao
            // 
            this.clnPopulacao.Text = "Populacao";
            this.clnPopulacao.Width = 118;
            // 
            // clnArea
            // 
            this.clnArea.Text = "Area";
            this.clnArea.Width = 105;
            // 
            // clnFuso
            // 
            this.clnFuso.Text = "Fuso horario";
            this.clnFuso.Width = 70;
            // 
            // clnNomeNativo
            // 
            this.clnNomeNativo.Text = "Nome Nativo";
            this.clnNomeNativo.Width = 148;
            // 
            // lstBandeira
            // 
            this.lstBandeira.FormattingEnabled = true;
            this.lstBandeira.Location = new System.Drawing.Point(293, 327);
            this.lstBandeira.Name = "lstBandeira";
            this.lstBandeira.Size = new System.Drawing.Size(414, 264);
            this.lstBandeira.TabIndex = 20;
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.txtContent);
            this.grbPesquisa.Controls.Add(this.lstBandeira);
            this.grbPesquisa.Controls.Add(this.lstVPaises);
            this.grbPesquisa.Controls.Add(this.txtNomeNat);
            this.grbPesquisa.Controls.Add(this.txtFuso);
            this.grbPesquisa.Controls.Add(this.txtArea);
            this.grbPesquisa.Controls.Add(this.txtPopulacao);
            this.grbPesquisa.Controls.Add(this.txtSubReg);
            this.grbPesquisa.Controls.Add(this.txtRegiao);
            this.grbPesquisa.Controls.Add(this.txtCapital);
            this.grbPesquisa.Controls.Add(this.txtNome);
            this.grbPesquisa.Controls.Add(this.btnBandeira);
            this.grbPesquisa.Controls.Add(this.btnLimpar);
            this.grbPesquisa.Controls.Add(this.btnTodos);
            this.grbPesquisa.Controls.Add(this.btnNomeNat);
            this.grbPesquisa.Controls.Add(this.btnFuso);
            this.grbPesquisa.Controls.Add(this.btnArea);
            this.grbPesquisa.Controls.Add(this.btnPopulacao);
            this.grbPesquisa.Controls.Add(this.btnSubReg);
            this.grbPesquisa.Controls.Add(this.btnRegiao);
            this.grbPesquisa.Controls.Add(this.btnCapital);
            this.grbPesquisa.Controls.Add(this.btnNome);
            this.grbPesquisa.Location = new System.Drawing.Point(17, 19);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(1298, 604);
            this.grbPesquisa.TabIndex = 21;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Pesquisa paises por:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 314);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(223, 200);
            this.txtContent.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 635);
            this.Controls.Add(this.grbPesquisa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Button btnCapital;
        private System.Windows.Forms.Button btnRegiao;
        private System.Windows.Forms.Button btnSubReg;
        private System.Windows.Forms.Button btnPopulacao;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnFuso;
        private System.Windows.Forms.Button btnNomeNat;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBandeira;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtRegiao;
        private System.Windows.Forms.TextBox txtSubReg;
        private System.Windows.Forms.TextBox txtPopulacao;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtFuso;
        private System.Windows.Forms.TextBox txtNomeNat;
        private System.Windows.Forms.ListView lstVPaises;
        private System.Windows.Forms.ColumnHeader clnNome;
        private System.Windows.Forms.ColumnHeader clnCapital;
        private System.Windows.Forms.ColumnHeader clnRegiao;
        private System.Windows.Forms.ColumnHeader clnSubReg;
        private System.Windows.Forms.ColumnHeader clnPopulacao;
        private System.Windows.Forms.ColumnHeader clnArea;
        private System.Windows.Forms.ColumnHeader clnFuso;
        private System.Windows.Forms.ColumnHeader clnNomeNativo;
        private System.Windows.Forms.ListBox lstBandeira;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.TextBox txtContent;
    }
}

