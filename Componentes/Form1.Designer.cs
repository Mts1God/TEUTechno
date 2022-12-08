
namespace Componentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpbfrutas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbfrutas = new System.Windows.Forms.ComboBox();
            this.txtselecione = new System.Windows.Forms.TextBox();
            this.txtfrutasselecionadas = new System.Windows.Forms.TextBox();
            this.lblfrutasselecionadas = new System.Windows.Forms.Label();
            this.lblfrutaslistadas2 = new System.Windows.Forms.Label();
            this.ltbfrutas = new System.Windows.Forms.ListBox();
            this.lblfrutaslistadas = new System.Windows.Forms.Label();
            this.btnselecionar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btninserir = new System.Windows.Forms.Button();
            this.gpbfrutas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbfrutas
            // 
            this.gpbfrutas.Controls.Add(this.label5);
            this.gpbfrutas.Controls.Add(this.label4);
            this.gpbfrutas.Controls.Add(this.label3);
            this.gpbfrutas.Controls.Add(this.label2);
            this.gpbfrutas.Controls.Add(this.label1);
            this.gpbfrutas.Location = new System.Drawing.Point(164, 88);
            this.gpbfrutas.Name = "gpbfrutas";
            this.gpbfrutas.Size = new System.Drawing.Size(200, 100);
            this.gpbfrutas.TabIndex = 0;
            this.gpbfrutas.TabStop = false;
            this.gpbfrutas.Text = "Frutas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1-Banana";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2-Maça";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3-Pera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "4-Melancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "5-Sair";
            // 
            // cbbfrutas
            // 
            this.cbbfrutas.FormattingEnabled = true;
            this.cbbfrutas.Location = new System.Drawing.Point(476, 261);
            this.cbbfrutas.Name = "cbbfrutas";
            this.cbbfrutas.Size = new System.Drawing.Size(121, 21);
            this.cbbfrutas.TabIndex = 6;
            // 
            // txtselecione
            // 
            this.txtselecione.Location = new System.Drawing.Point(164, 45);
            this.txtselecione.Name = "txtselecione";
            this.txtselecione.Size = new System.Drawing.Size(100, 20);
            this.txtselecione.TabIndex = 0;
            this.txtselecione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtselecione_KeyDown);
            // 
            // txtfrutasselecionadas
            // 
            this.txtfrutasselecionadas.Enabled = false;
            this.txtfrutasselecionadas.Location = new System.Drawing.Point(167, 262);
            this.txtfrutasselecionadas.Name = "txtfrutasselecionadas";
            this.txtfrutasselecionadas.Size = new System.Drawing.Size(100, 20);
            this.txtfrutasselecionadas.TabIndex = 1;
            // 
            // lblfrutasselecionadas
            // 
            this.lblfrutasselecionadas.AutoSize = true;
            this.lblfrutasselecionadas.Location = new System.Drawing.Point(164, 246);
            this.lblfrutasselecionadas.Name = "lblfrutasselecionadas";
            this.lblfrutasselecionadas.Size = new System.Drawing.Size(91, 13);
            this.lblfrutasselecionadas.TabIndex = 5;
            this.lblfrutasselecionadas.Text = "Fruta selecionada";
            // 
            // lblfrutaslistadas2
            // 
            this.lblfrutaslistadas2.AutoSize = true;
            this.lblfrutaslistadas2.Location = new System.Drawing.Point(473, 246);
            this.lblfrutaslistadas2.Name = "lblfrutaslistadas2";
            this.lblfrutaslistadas2.Size = new System.Drawing.Size(64, 13);
            this.lblfrutaslistadas2.TabIndex = 6;
            this.lblfrutaslistadas2.Text = "Fruta listada";
            // 
            // ltbfrutas
            // 
            this.ltbfrutas.FormattingEnabled = true;
            this.ltbfrutas.Location = new System.Drawing.Point(477, 93);
            this.ltbfrutas.Name = "ltbfrutas";
            this.ltbfrutas.Size = new System.Drawing.Size(120, 95);
            this.ltbfrutas.TabIndex = 7;
            // 
            // lblfrutaslistadas
            // 
            this.lblfrutaslistadas.AutoSize = true;
            this.lblfrutaslistadas.Location = new System.Drawing.Point(473, 77);
            this.lblfrutaslistadas.Name = "lblfrutaslistadas";
            this.lblfrutaslistadas.Size = new System.Drawing.Size(64, 13);
            this.lblfrutaslistadas.TabIndex = 8;
            this.lblfrutaslistadas.Text = "Fruta listada";
            // 
            // btnselecionar
            // 
            this.btnselecionar.Location = new System.Drawing.Point(167, 373);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(75, 23);
            this.btnselecionar.TabIndex = 2;
            this.btnselecionar.Text = "Selecionar";
            this.btnselecionar.UseVisualStyleBackColor = true;
            this.btnselecionar.Click += new System.EventHandler(this.btnselecionar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(409, 373);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(289, 373);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "&sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(161, 29);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(192, 13);
            this.lbltitulo.TabIndex = 12;
            this.lbltitulo.Text = "Digite o número para selecionar a fruta:";
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(522, 373);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(75, 23);
            this.btninserir.TabIndex = 5;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnselecionar);
            this.Controls.Add(this.lblfrutaslistadas);
            this.Controls.Add(this.ltbfrutas);
            this.Controls.Add(this.lblfrutaslistadas2);
            this.Controls.Add(this.lblfrutasselecionadas);
            this.Controls.Add(this.txtfrutasselecionadas);
            this.Controls.Add(this.txtselecione);
            this.Controls.Add(this.cbbfrutas);
            this.Controls.Add(this.gpbfrutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit";
            this.gpbfrutas.ResumeLayout(false);
            this.gpbfrutas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbfrutas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbfrutas;
        private System.Windows.Forms.TextBox txtselecione;
        private System.Windows.Forms.TextBox txtfrutasselecionadas;
        private System.Windows.Forms.Label lblfrutasselecionadas;
        private System.Windows.Forms.Label lblfrutaslistadas2;
        private System.Windows.Forms.ListBox ltbfrutas;
        private System.Windows.Forms.Label lblfrutaslistadas;
        private System.Windows.Forms.Button btnselecionar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btninserir;
    }
}