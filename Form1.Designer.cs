namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.poltronaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileiraTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a poltrona:";
            // 
            // poltronaTextBox
            // 
            this.poltronaTextBox.Location = new System.Drawing.Point(393, 101);
            this.poltronaTextBox.Name = "poltronaTextBox";
            this.poltronaTextBox.Size = new System.Drawing.Size(100, 20);
            this.poltronaTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite a fileira:";
            // 
            // fileiraTextBox
            // 
            this.fileiraTextBox.Location = new System.Drawing.Point(393, 140);
            this.fileiraTextBox.Name = "fileiraTextBox";
            this.fileiraTextBox.Size = new System.Drawing.Size(100, 20);
            this.fileiraTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "0. Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BotaoFinalizar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "1. Reservar poltrona";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Botaoparareservar);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "2. mapa de ocupação";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BotaodoMapa);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "3. faturamento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BotaoFaturamento);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(354, 343);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 8;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.BotaodeSalvar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Projeto Bilheteria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileiraTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poltronaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox poltronaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileiraTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label label3;
    }
}

