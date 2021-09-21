namespace AdicionarBreakPoints
{
    partial class AdicionarBreakPointsForm
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
            this.PalavraBuscaTextBox = new System.Windows.Forms.TextBox();
            this.CaminhoProjetoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GerarXmlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PalavraBuscaTextBox
            // 
            this.PalavraBuscaTextBox.Location = new System.Drawing.Point(12, 32);
            this.PalavraBuscaTextBox.Name = "PalavraBuscaTextBox";
            this.PalavraBuscaTextBox.Size = new System.Drawing.Size(353, 20);
            this.PalavraBuscaTextBox.TabIndex = 0;
            // 
            // CaminhoProjetoTextBox
            // 
            this.CaminhoProjetoTextBox.Location = new System.Drawing.Point(12, 91);
            this.CaminhoProjetoTextBox.Name = "CaminhoProjetoTextBox";
            this.CaminhoProjetoTextBox.Size = new System.Drawing.Size(353, 20);
            this.CaminhoProjetoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palavra que deseja Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caminho Projeto";
            // 
            // GerarXmlButton
            // 
            this.GerarXmlButton.Location = new System.Drawing.Point(205, 126);
            this.GerarXmlButton.Name = "GerarXmlButton";
            this.GerarXmlButton.Size = new System.Drawing.Size(160, 23);
            this.GerarXmlButton.TabIndex = 4;
            this.GerarXmlButton.Text = "Gerar XML com BreakPoints";
            this.GerarXmlButton.UseVisualStyleBackColor = true;
            this.GerarXmlButton.Click += new System.EventHandler(this.GerarXmlButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 163);
            this.Controls.Add(this.GerarXmlButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaminhoProjetoTextBox);
            this.Controls.Add(this.PalavraBuscaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PalavraBuscaTextBox;
        private System.Windows.Forms.TextBox CaminhoProjetoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GerarXmlButton;
    }
}

