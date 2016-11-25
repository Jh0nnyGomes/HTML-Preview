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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strumentiMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TemiMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.chiaroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
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
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStrip,
            this.strumentiMenuStrip,
            this.TemiMenuStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(284, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.chiudiToolStripMenuItem});
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(37, 20);
            this.fileMenuStrip.Text = "File";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.apriToolStripMenuItem.Text = "Apri";
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            // 
            // strumentiMenuStrip
            // 
            this.strumentiMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strumentiMenuStrip.Name = "strumentiMenuStrip";
            this.strumentiMenuStrip.Size = new System.Drawing.Size(71, 20);
            this.strumentiMenuStrip.Text = "Strumenti";
            // 
            // TemiMenuStrip
            // 
            this.TemiMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TemiMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiaroToolStripMenuItem,
            this.scuroToolStripMenuItem,
            this.personalizzaToolStripMenuItem});
            this.TemiMenuStrip.Name = "TemiMenuStrip";
            this.TemiMenuStrip.Size = new System.Drawing.Size(45, 20);
            this.TemiMenuStrip.Text = "Temi";
            // 
            // chiaroToolStripMenuItem
            // 
            this.chiaroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.chiaroToolStripMenuItem.Name = "chiaroToolStripMenuItem";
            this.chiaroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chiaroToolStripMenuItem.Text = "Chiaro";
            this.chiaroToolStripMenuItem.Click += new System.EventHandler(this.chiaroToolStripMenuItem_Click);
            // 
            // scuroToolStripMenuItem
            // 
            this.scuroToolStripMenuItem.AutoToolTip = true;
            this.scuroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.scuroToolStripMenuItem.Name = "scuroToolStripMenuItem";
            this.scuroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scuroToolStripMenuItem.Text = "Scuro";
            this.scuroToolStripMenuItem.Click += new System.EventHandler(this.scuroToolStripMenuItem_Click);
            // 
            // personalizzaToolStripMenuItem
            // 
            this.personalizzaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.personalizzaToolStripMenuItem.Name = "personalizzaToolStripMenuItem";
            this.personalizzaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personalizzaToolStripMenuItem.Text = "Personalizza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txt_css);
            this.Controls.Add(this.txt_html);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_html;
        private System.Windows.Forms.TextBox txt_css;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strumentiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TemiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem chiaroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizzaToolStripMenuItem;
    }
}

