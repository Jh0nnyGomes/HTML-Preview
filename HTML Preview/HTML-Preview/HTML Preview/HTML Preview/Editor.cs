using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManagement;

namespace HTML_Preview
{
    public partial class Editor : Form
    {
        #region Grafica

        Color BGColorDark = System.Drawing.ColorTranslator.FromHtml("#171616"); 
        Color TxtBoxColorDark = System.Drawing.ColorTranslator.FromHtml("#272626");
        Color TextColorWhite = System.Drawing.ColorTranslator.FromHtml("#fff");

        Color BGColorLight = System.Drawing.ColorTranslator.FromHtml("#ececec");
        Color TxtBoxColorLight = System.Drawing.ColorTranslator.FromHtml("#fff");
        Color TextColorBlack = System.Drawing.ColorTranslator.FromHtml("#000");

        #endregion

        FileManager FM = new FileManager();
        string[] filePaths;
        public string ProjectPath;

        public Editor()
        {
            InitializeComponent();
            FM.ResourceInitialize();//inizializza il file di risorse
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Grafica

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

#endregion 
        }

        #region Menu

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

        #endregion

        //Aggiorna la Pagina quando si scrive
        private void Refresh_OnKeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            int i;//l'indice è 0 per html 1 per css

            if (t.Name == txt_html.Name)
                i = 0;
            else
                i = 1;

            //aggiorna il file
            if (!FM.TryToWrite(filePaths[i], txt_html.Text, false))
            {
                MessageBox.Show("Impossibile scrivere sul file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Wb_Preview.Navigate(filePaths[i]);
        }

        //carica progetto
        private void Btn_LoadProject_Click(object sender, EventArgs e)//////////////////
        {
            if (PathDialog(out ProjectPath))
            {
            Extract:
                if (Extract(ProjectPath, out fileContent))
                    return;
                else
                {
                    DialogResult dr = MessageBox.Show("file non trovati", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.Retry)
                        goto Extract;
                }
            }
            else
                return;
        }

        private void Btn_NewProject_Click(object sender, EventArgs e)
        {
            //sceglie la cartella in cui inserirlo
            string[] path;
            if (PathDialog(out path))
            {
                string title = null;
                if (!FindTitle(out title))
                    title = "Sample";

                FM.FileAdd(title, ".html", txt_html.Text);
                FM.FileAdd(title, ".html", txt_html.Text);
            }
        }

        //continua dal progetto precedente
        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            //contenuto dei file html[0] e css[1]
            string[] fileContent = new string[0];

            //legge dalle risorse
            List<string> resources = new List<string>();//contiene i dati del file di risorse
            if (FM.ResourceReading(out resources))//se riesce a leggere il file 
            {
                if (Extract(resources[0], out fileContent))//se riesce ad estrarre i contenuti del file indirizzato dalle risorse
                {
                    txt_html.Text = fileContent[0];
                    txt_css.Text = fileContent[1];
                    return;
                }
            }
            MessageBox.Show("Nessun Progetto in corso trovato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region Gestione File

        //estrae i file se li trova
        private bool Extract(string path, out string[] file)
        {
            file = new string[2];//file html e css
            //entrare dentro la cartella
            string[] FilePath = System.IO.Directory.GetFiles(path);

            //cercare i file html e css, [0] è html, [1] è css
            int ok = 0;//numero di file trovati
            for (int i = 0; i < FilePath.Length || ok != 2; i--)
            {
                string p = System.IO.Path.GetFileName(FilePath[i]);
                if (FileManager.ItsExtensionIs(p, ".html"))
                {
                    file[0] = FileManager.ToString(FilePath[i]);
                    ok++;
                }
                else if (FileManager.ItsExtensionIs(p, ".css"))
                {
                    file[1] = FileManager.ToString(FilePath[i]);
                    ok++;
                }
            }
            if (ok != 2)
                return false;//se mancano i file
            else
                return true;
        }

        bool PathDialog(out string path)
        {
            path = null;
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                path = f.SelectedPath;
                return true;
            }
            return false;
        }

        bool PathDialog(out string[] path)
        {
            path = null;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "html files (*.html)|*.html|css files (*.css)|*.css";
            f.Title = "Carica i file";
            if (f.ShowDialog() == DialogResult.OK)
            {
                path = f.FileNames;
                return true;
            }
            return false;
        }

        #endregion

        #region Gestione Textbox

        bool FindTitle(out string title)
        {
            //ottiene la posizione iniziale del titolo
            int index, end;
            for (index = 0; index < txt_html.Text.Length - 7; index++)
                if (txt_html.Text.Substring(index, 7).ToUpper() == "<TITLE>")
                    break;
            //ottiene la posizione finale
            for (end = index; end < txt_html.Text.Length - 7; end++)
                if (txt_html.Text.Substring(end, 7).ToUpper() == "</TITLE>")
                    break;

            title = txt_html.Text.Substring(index, end - index);
            if (title != null)
                return true;
            else
                return false;
        }

        #endregion
    }
}
