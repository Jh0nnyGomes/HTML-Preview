namespace HTML_Preview
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_html = new System.Windows.Forms.TextBox();
            this.txt_css = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txt_html
            // 
            this.txt_html.Location = new System.Drawing.Point(2, 34);
            this.txt_html.Multiline = true;
            this.txt_html.Name = "txt_html";
            this.txt_html.Size = new System.Drawing.Size(86, 20);
            this.txt_html.TabIndex = 0;
            // 
            // txt_css
            // 
            this.txt_css.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_css.Location = new System.Drawing.Point(94, 34);
            this.txt_css.Multiline = true;
            this.txt_css.Name = "txt_css";
            this.txt_css.Size = new System.Drawing.Size(94, 20);
            this.txt_css.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(194, 34);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(89, 20);
            this.webBrowser1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txt_css);
            this.Controls.Add(this.txt_html);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_html;
        private System.Windows.Forms.TextBox txt_css;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

