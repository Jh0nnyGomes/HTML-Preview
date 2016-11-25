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
        Color BGColor = System.Drawing.ColorTranslator.FromHtml("#171616");
        Color TxtBoxColor = System.Drawing.ColorTranslator.FromHtml("#272626");
        Color TextColor = System.Drawing.ColorTranslator.FromHtml("#fff");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.BackColor = BGColor;

            txt_html.Height = Height - 100;
            txt_html.Width = Width / 3 - 20;
            txt_html.BackColor = TxtBoxColor;
            txt_html.BorderStyle = BorderStyle.None;
            txt_html.ForeColor = TextColor;

            txt_css.Height = Height - 100;
            txt_css.Width = Width / 3 - 20;
            txt_css.BackColor = TxtBoxColor;
            txt_css.BorderStyle = BorderStyle.None;
            txt_css.ForeColor = TextColor;

            webBrowser1.Height = Height - 100;
            webBrowser1.Width = Width / 3 - 40;

            txt_html.Location = new Point(30, 30);

            txt_css.Location = new Point((Width / 3) + 15, 30);

            webBrowser1.Location = new Point(((Width / 3) * 2), 30);
        }
    }
}
