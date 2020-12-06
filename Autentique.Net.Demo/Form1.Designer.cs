namespace Autentique.Net.Demo
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
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListDocuments = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(12, 34);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(445, 20);
            this.txtAccessToken.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AccessToken";
            // 
            // btnListDocuments
            // 
            this.btnListDocuments.Location = new System.Drawing.Point(12, 60);
            this.btnListDocuments.Name = "btnListDocuments";
            this.btnListDocuments.Size = new System.Drawing.Size(101, 31);
            this.btnListDocuments.TabIndex = 2;
            this.btnListDocuments.Text = "List Documents";
            this.btnListDocuments.UseVisualStyleBackColor = true;
            this.btnListDocuments.Click += new System.EventHandler(this.btnListDocuments_Click);
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(12, 134);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(672, 298);
            this.txtResults.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnListDocuments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccessToken);
            this.Name = "Form1";
            this.Text = "SDK Autentique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListDocuments;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label2;
    }
}

