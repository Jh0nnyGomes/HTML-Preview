using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Preview
{
    public partial class Form1 : Form
    {
        Color BGColorDark = System.Drawing.ColorTranslator.FromHtml("#171616"); 
        Color TxtBoxColorDark = System.Drawing.ColorTranslator.FromHtml("#272626");
        Color TextColorWhite = System.Drawing.ColorTranslator.FromHtml("#fff");

        Color BGColorLight = System.Drawing.ColorTranslator.FromHtml("#ececec");
        Color TxtBoxColorLight = System.Drawing.ColorTranslator.FromHtml("#fff");
        Color TextColorBlack = System.Drawing.ColorTranslator.FromHtml("#000");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.BackColor = BGColorDark;

            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.BackColor = Color.Transparent;
            btn_new.ForeColor = TextColorWhite;

            panel1.Dock = DockStyle.Fill;
            panel1.Controls.Add(btn_new);
            panel1.Controls.Add(btn_load);
            panel1.Controls.Add(btn_continue);

            panel2.Hide();

            //Posizionamento, Stile, Dimensioni TextBox dell'HTML
            txt_html.Height = Height - 100;
            txt_html.Width = Width / 3 - 20;
            txt_html.BackColor = TxtBoxColorDark;
            txt_html.ForeColor = TextColorWhite;
            txt_html.BorderStyle = BorderStyle.None;
            txt_html.Font = new Font("Cambria", 16);
            txt_html.Location = new Point(30, 30);

            //Posizionamento, Stile, Dimensioni TextBox del CSS
            txt_css.Height = Height - 100;
            txt_css.Width = Width / 3 - 20;
            txt_css.BackColor = TxtBoxColorDark;
            txt_css.ForeColor = TextColorWhite;
            txt_css.BorderStyle = BorderStyle.None;
            txt_css.Font = new Font("Cambria", 16);
            txt_css.Location = new Point((Width / 3) + 15, 30);

            //Posizionamento e Dimensioni del visualizzatore WEB
            webBrowser1.Height = Height - 100;
            webBrowser1.Width = Width / 3 - 40;
            webBrowser1.Location = new Point(((Width / 3) * 2), 30);

            //Personalizzazione del Menù
            menuStrip.BackColor = Color.Transparent;
            menuStrip.ForeColor = TextColorWhite;

            scuroToolStripMenuItem.ToolTipText = "Predefinito";
            
            panel2.Dock = DockStyle.Fill;
            panel2.Controls.Add(menuStrip);
            panel2.Controls.Add(txt_html);
            panel2.Controls.Add(txt_css);
            panel2.Controls.Add(webBrowser1);
        }

        private void chiaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = BGColorLight;

            txt_html.BackColor = TxtBoxColorLight;
            txt_html.ForeColor = TextColorBlack;

            txt_css.BackColor = TxtBoxColorLight;
            txt_css.ForeColor = TextColorBlack;


            menuStrip.ForeColor = TextColorBlack;
        }

        private void scuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = BGColorDark;

            txt_html.BackColor = TxtBoxColorDark;
            txt_html.ForeColor = TextColorWhite;

            txt_css.BackColor = TxtBoxColorDark;
            txt_css.ForeColor = TextColorWhite;


            menuStrip.ForeColor = TextColorWhite;
        }
    }
}
