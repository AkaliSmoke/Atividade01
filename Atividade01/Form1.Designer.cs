namespace Atividade01
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
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnIdade = new System.Windows.Forms.Button();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnVerificarLetra = new System.Windows.Forms.Button();
            this.btnAprendendo = new System.Windows.Forms.Button();
            this.btnContar10 = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(59, 42);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(275, 20);
            this.txtCampo.TabIndex = 0;
            this.txtCampo.TextChanged += new System.EventHandler(this.txtCampo_TextChanged);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(59, 69);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "Resultado";
            // 
            // btnIdade
            // 
            this.btnIdade.Location = new System.Drawing.Point(56, 139);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(127, 55);
            this.btnIdade.TabIndex = 2;
            this.btnIdade.Text = "Calcular Idade";
            this.btnIdade.UseVisualStyleBackColor = true;
            this.btnIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(207, 139);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(127, 55);
            this.btnTabuada.TabIndex = 3;
            this.btnTabuada.Text = "Calcular Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnVerificarLetra
            // 
            this.btnVerificarLetra.Location = new System.Drawing.Point(56, 201);
            this.btnVerificarLetra.Name = "btnVerificarLetra";
            this.btnVerificarLetra.Size = new System.Drawing.Size(127, 51);
            this.btnVerificarLetra.TabIndex = 4;
            this.btnVerificarLetra.Text = "Verificar Letra";
            this.btnVerificarLetra.UseVisualStyleBackColor = true;
            // 
            // btnAprendendo
            // 
            this.btnAprendendo.Location = new System.Drawing.Point(207, 201);
            this.btnAprendendo.Name = "btnAprendendo";
            this.btnAprendendo.Size = new System.Drawing.Size(127, 51);
            this.btnAprendendo.TabIndex = 5;
            this.btnAprendendo.Text = "Estou Aprendendo";
            this.btnAprendendo.UseVisualStyleBackColor = true;
            this.btnAprendendo.Click += new System.EventHandler(this.btnAprendendo_Click);
            // 
            // btnContar10
            // 
            this.btnContar10.Location = new System.Drawing.Point(56, 258);
            this.btnContar10.Name = "btnContar10";
            this.btnContar10.Size = new System.Drawing.Size(127, 51);
            this.btnContar10.TabIndex = 6;
            this.btnContar10.Text = "Contar até 10";
            this.btnContar10.UseVisualStyleBackColor = true;
            this.btnContar10.Click += new System.EventHandler(this.btnContar10_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(207, 258);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(127, 51);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "Mini Jogo";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 371);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnContar10);
            this.Controls.Add(this.btnAprendendo);
            this.Controls.Add(this.btnVerificarLetra);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.btnIdade);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txtCampo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button btnVerificarLetra;
        private System.Windows.Forms.Button btnAprendendo;
        private System.Windows.Forms.Button btnContar10;
        private System.Windows.Forms.Button btnJogar;
    }
}

