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

        //string[] fileMenuList = new string[] { "Apri", "Salva", "Chiudi" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.BackColor = BGColorDark;

            txt_html.Height = Height - 100;
            txt_html.Width = Width / 3 - 20;
            txt_html.BackColor = TxtBoxColorDark;
            txt_html.ForeColor = TextColorWhite;
            txt_html.BorderStyle = BorderStyle.None;
            txt_html.Font = new Font("Cambria", 16);

            txt_css.Height = Height - 100;
            txt_css.Width = Width / 3 - 20;
            txt_css.BackColor = TxtBoxColorDark;
            txt_css.ForeColor = TextColorWhite;
            txt_css.BorderStyle = BorderStyle.None;
            txt_css.Font = new Font("Cambria", 16);


            webBrowser1.Height = Height - 100;
            webBrowser1.Width = Width / 3 - 40;

            txt_html.Location = new Point(30, 30);

            txt_css.Location = new Point((Width / 3) + 15, 30);

            webBrowser1.Location = new Point(((Width / 3) * 2), 30);

            menuStrip.BackColor = Color.Transparent;
            menuStrip.ForeColor = TextColorWhite;

            scuroToolStripMenuItem.ToolTipText = "Predefinito";

            //file_menu.Location = new Point(5, 5);
            //file_menu.Size = new Size(40, 24);
            //file_menu.BackColor = BGColor;
            //file_menu.FlatStyle = FlatStyle.System;
            //file_menu.MaxDropDownItems = 3;
            //file_menu.DropDownStyle = ComboBoxStyle.DropDownList;
            //file_menu.Items.AddRange(fileMenuList);
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
