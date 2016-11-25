namespace HTML_Preview
{
    partial class Editor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStrip,
            this.strumentiMenuStrip,
            this.TemiMenuStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(161, 24);
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
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.apriToolStripMenuItem.Text = "Apri";
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
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
            this.scuroToolStripMenuItem});
            this.TemiMenuStrip.Name = "TemiMenuStrip";
            this.TemiMenuStrip.Size = new System.Drawing.Size(45, 20);
            this.TemiMenuStrip.Text = "Temi";
            // 
            // chiaroToolStripMenuItem
            // 
            this.chiaroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.chiaroToolStripMenuItem.Name = "chiaroToolStripMenuItem";
            this.chiaroToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.chiaroToolStripMenuItem.Text = "Chiaro";
            this.chiaroToolStripMenuItem.Click += new System.EventHandler(this.chiaroToolStripMenuItem_Click);
            // 
            // scuroToolStripMenuItem
            // 
            this.scuroToolStripMenuItem.AutoToolTip = true;
            this.scuroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.scuroToolStripMenuItem.Name = "scuroToolStripMenuItem";
            this.scuroToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.scuroToolStripMenuItem.Text = "Scuro";
            this.scuroToolStripMenuItem.Click += new System.EventHandler(this.scuroToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(553, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // btn_new
            // 
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.Location = new System.Drawing.Point(159, 305);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(107, 23);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "Nuovo Progetto";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(286, 304);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Carica";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(380, 305);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(75, 23);
            this.btn_continue.TabIndex = 7;
            this.btn_continue.Text = "Continua";
            this.btn_continue.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(509, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Panel panel2;
    }
}

