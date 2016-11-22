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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            txt_html.Height = Height;
            txt_html.Width = Width / 3;

            txt_css.Height = Height;
            txt_css.Width = Width / 3;

            webBrowser1.Height = Height;
            webBrowser1.Width = Width / 3;

            txt_html.Location = new Point(10, 10);

            txt_css.Location = new Point((Width / 3), 10);

            webBrowser1.Location = new Point(((Width / 3) * 2), 10);
        }
    }
}
