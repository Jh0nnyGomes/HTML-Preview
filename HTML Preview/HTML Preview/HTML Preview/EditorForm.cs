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
    struct DataColor
    {
        public string Bg_Color;

        public string html_BgColor;
        public string html_ForeColor;

        public string css_BgColor;
        public string css_ForeColor;

        public string menu_ForeColor;

        public DataColor(string Bg, string html_bg, string html_fore, string css_bg, string css_fore, string menu_fore)
        {
            Bg_Color = Bg;

            html_BgColor = html_bg;
            html_ForeColor = html_fore;

            css_BgColor = css_bg;
            css_ForeColor = css_fore;

            menu_ForeColor = menu_fore;
        }

        public List<string> Compact()
        {
            List<string> d = new List<string>();
            d.Add(Bg_Color);
            d.Add(html_BgColor);
            d.Add(html_ForeColor);
            d.Add(css_BgColor);
            d.Add(css_ForeColor);
            d.Add(menu_ForeColor);


            return d;
        }
    }

    public partial class EditorForm : Form
    {
        Color BGColorDark = System.Drawing.ColorTranslator.FromHtml("#171616");
        Color TxtBoxColorDark = System.Drawing.ColorTranslator.FromHtml("#272626");
        Color TextColorWhite = System.Drawing.ColorTranslator.FromHtml("#fff");

        Color BGColorLight = System.Drawing.ColorTranslator.FromHtml("#ececec");
        Color TxtBoxColorLight = System.Drawing.ColorTranslator.FromHtml("#fff");
        Color TextColorBlack = System.Drawing.ColorTranslator.FromHtml("#000");

        FileManager FM = new FileManager();
        DataColor setting;

        string[] fileNames;

        public EditorForm()
        {
            InitializeComponent();
            FM.ResourceInitialize();//inizializza il file di risorse
            
            //prova a cercare delle preimpostazioni, se le trova le carica nello struct
            List<string> data = new List<string>();
            if (FM.ResourceReading(out data) && data.Count == 7)
                setting = new DataColor(data[1], data[2], data[3], data[4], data[5], data[6]);
            else//imposta setting
                setting = new DataColor("#171616", "#272626", "#fff", "#272626", "#fff", "#fff");

        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.BackColor = ColorTranslator.FromHtml(setting.Bg_Color); ;

            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.BackColor = Color.Transparent;
            btn_new.ForeColor = TextColorWhite;
            btn_new.Size = new Size(150, 30);
            btn_new.Location = new Point((Width / 2) - (btn_new.Size.Width / 2), (Height / 2) - 200);

            btn_load.FlatStyle = FlatStyle.Flat;
            btn_load.BackColor = Color.Transparent;
            btn_load.ForeColor = TextColorWhite;
            btn_load.Size = new Size(150, 30);
            btn_load.Location = new Point((Width / 2) - (btn_load.Size.Width / 2), Height / 2);

            btn_continue.FlatStyle = FlatStyle.Flat;
            btn_continue.BackColor = Color.Transparent;
            btn_continue.ForeColor = TextColorWhite;
            btn_continue.Size = new Size(150, 30);
            btn_continue.Location = new Point((Width / 2) - (btn_continue.Size.Width / 2), (Height / 2) + 200);

            Pnl_Start.Dock = DockStyle.Fill;
            Pnl_Start.Controls.Add(btn_new);
            Pnl_Start.Controls.Add(btn_load);
            Pnl_Start.Controls.Add(btn_continue);

            Pnl_Edit.Visible = false;

            //Posizionamento, Stile, Dimensioni TextBox dell'HTML
            txt_html.Height = Height - 100;
            txt_html.Width = Width / 3 - 20;
            txt_html.BackColor = ColorTranslator.FromHtml(setting.html_BgColor);
            txt_html.ForeColor = ColorTranslator.FromHtml(setting.html_ForeColor); ;
            txt_html.BorderStyle = BorderStyle.None;
            txt_html.Font = new Font("Cambria", 16);
            txt_html.Location = new Point(30, 30);

            //Posizionamento, Stile, Dimensioni TextBox del CSS
            txt_css.Height = Height - 100;
            txt_css.Width = Width / 3 - 20;
            txt_css.BackColor = ColorTranslator.FromHtml(setting.css_BgColor); ;
            txt_css.ForeColor = ColorTranslator.FromHtml(setting.css_ForeColor); ;
            txt_css.BorderStyle = BorderStyle.None;
            txt_css.Font = new Font("Cambria", 16);
            txt_css.Location = new Point((Width / 3) + 15, 30);

            //Posizionamento e Dimensioni del visualizzatore WEB
            Wb_Preview.Height = Height - 100;
            Wb_Preview.Width = Width / 3 - 40;
            Wb_Preview.Location = new Point(((Width / 3) * 2), 30);

            //Personalizzazione del Menù
            menuStrip.BackColor = Color.Transparent;
            menuStrip.ForeColor = ColorTranslator.FromHtml(setting.menu_ForeColor); 

            scuroToolStripMenuItem.ToolTipText = "Predefinito";

            Pnl_Edit.Dock = DockStyle.Fill;
            Pnl_Edit.Controls.Add(menuStrip);
            Pnl_Edit.Controls.Add(txt_html);
            Pnl_Edit.Controls.Add(txt_css);
            Pnl_Edit.Controls.Add(Wb_Preview);
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

        #region start_pnl        

        private void Btn_LoadProject_Click(object sender, EventArgs e)
        {
            string[][] data = new string[2][];
            if (!LoadProject(out data[0], out data[1]))
                MessageBox.Show("C'è stato un errore nel caricamento della pagina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Initialize(data[0], data[1]);
        }
        //nuovo
        private void Btn_NewProject_Click(object sender, EventArgs e)
        {
            string[] data = new string[2];
            if (NewProject(out data))                
                Initialize(data);
        }
        //continua dal progetto precedente
        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            string[][] data = new string[2][];
            if (!ContinueProject(out data[0], out data[1]))
                MessageBox.Show("Impossibile caricare l'ultima versione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Initialize(data[0], data[1]);
        }
        #endregion

        #region Gestione File

        //"Riempie l'editor"
        private void Initialize(string[] FilePaths)
        {
            fileNames = FilePaths;
            FM.FilePath = fileNames.ToList();

            Pnl_Start.Visible = false;
            Pnl_Edit.Visible = true;

            Wb_Preview.Navigate("http://www.microsoft.com");
        }
        private void Initialize(string[] TextboxContent, string[] FilePaths)
        {
            txt_html.Text = TextboxContent[0];
            txt_css.Text = TextboxContent[1];

            fileNames = FilePaths;
            FM.FilePath = fileNames.ToList();

            Pnl_Start.Visible = false;
            Pnl_Edit.Visible = true;

            Wb_Preview.Navigate(fileNames[0]);
        }

        //Apre un progetto esistente
        bool LoadProject(out string[] content, out string[] paths)
        {
            content = new string[2];
            paths = new string[2];
        Top:
            if (PathDialog(out paths, "HTML/css files|*.html; *.css", true, "Carica I File neccessari"))//se il folder dialog ha prodotto i path
            {
                if (paths.Length > 2)//se l'utente sceglie più di due file
                {
                    MessageBox.Show("Carica al massimo 1 File HTML e 1 File CSS");
                    goto Top;
                }

                //alloca il contenuto dei file in base all'estensione
                for (int i = 0, ok = 0; i < paths.Length && ok != 2; i++)
                {
                    if (FileManager.ItsExtensionIs(paths[i], ".html"))
                        content[0] = FileManager.ToString(paths[i]);

                    else if (FileManager.ItsExtensionIs(paths[i], ".css"))
                        content[1] = FileManager.ToString(paths[i]);
                }
                return true;
            }
            return false;
        }

        //inizializza un nuovo progetto a livello di file
        bool NewProject(out string[] paths)
        {
            //sceglie la cartella in cui inserirlo
            string path;
            paths = new string[2];
            if (FolderDialog(out path))
            {
                FM.DirCreation(path, "Project", true);
                //aggiunge in automatico alla lista intera di paths del fileManager
                FM.FileAdd("(1)", "html", txt_html.Text);
                FM.FileAdd("(1)", "css", txt_html.Text);

                paths[0] = FM.FilePath[0];
                paths[1] = FM.FilePath[1];
                return true;
            }
            return false;
        }

        //continua l'ultimo progetto
        bool ContinueProject(out string[] content, out string[] fileNames)
        {
            List<string> path = new List<string>();
            fileNames = new string[2];
            content = new string[2];

            if (FM.ResourceReading(out path))//estrae l'indirizzo della cartella
            {
                if (Extract(path[0], out content, out fileNames))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Estrae i file css e html all'interno di una directory
        /// </summary>
        /// <param name="path">indirizzo della cartella</param>
        /// <param name="content">contenuto dei file</param>
        /// <returns></returns>
        bool Extract(string path, out string[] content, out string[] fileNames)
        {
            fileNames = new string[2];
            content = new string[2];//file html e css
            //entrare dentro la cartella
            string[] FilePath = System.IO.Directory.GetFiles(path);

            //cercare i file html e css, [0] è html, [1] è css
            int ok = 0;//numero di file trovati
            for (int i = 0; i < FilePath.Length || ok != 2; i++)
            {
                string p = System.IO.Path.GetFileName(FilePath[i]);
                if (FileManager.ItsExtensionIs(p, ".html"))
                {
                    content[0] = FileManager.ToString(FilePath[i]);
                    fileNames[0] = FilePath[i];
                    ok++;
                }
                else if (FileManager.ItsExtensionIs(p, ".css"))
                {
                    content[1] = FileManager.ToString(FilePath[i]);
                    fileNames[1] = FilePath[i];
                    ok++;
                }
            }
            if (ok != 2)
                return false;//se mancano i file
            else
                return true;
        }

        bool FolderDialog(out string path)
        {
            path = "";
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                path = f.SelectedPath;               
                return true;
            }
            return false;
        }

        bool PathDialog(out string[] path, string filter, bool multiselect, string title)
        {
            path = null;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = filter;
            f.Multiselect = multiselect;
            f.Title = title;
            if (f.ShowDialog() == DialogResult.OK)
            {
                path = f.FileNames;
                return true;
            }
            return false;
        }

        bool SaveSettings()
        {
            //monta la lista dei dat necessari
            List<string> dataSource = new List<string>();
            dataSource.Add(System.IO.Path.GetDirectoryName(fileNames[0]));
            foreach (string d in setting.Compact())
                dataSource.Add(d);
            //fa l'update con il file di risorse
            if (FM.ResourceUpdate(dataSource, false))
                return true;
            else
                return false;
        }

        #endregion

        #region Gestione Textbox

        //Aggiorna la Pagina quando si scrive
        private void Refresh_OnKeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Name == txt_html.Name)
            {
                //aggiorna il file
                if (!FM.TryToWrite(fileNames[0], txt_html.Text, false))
                {
                    MessageBox.Show("Impossibile scrivere sul file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //aggiorna il file css
                if (!FM.TryToWrite(fileNames[1], txt_css.Text, false))
                {
                    MessageBox.Show("Impossibile scrivere sul file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Wb_Preview.Navigate(fileNames[0]);
        }

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

        //salva le preferenze sul file
        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Pnl_Start.Visible == false)
            {
                if (MessageBox.Show("Sei sicuro di voler chiudere?\nLa prossima volta ricomincerai da qui!", "Closing", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (!SaveSettings())
                        MessageBox.Show("Impossibile Salvare i dati", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    e.Cancel = true;
            }
        }

        private void txt_html_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
