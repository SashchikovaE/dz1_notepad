using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace dz1_notepad
{
    public partial class Notepad : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;
        public string filename;
        public bool isFileChanged;
        FontSettings fos = new FontSettings();
        public Notepad()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
            fos = new FontSettings();
        }
        public void UpdateTextWithTitle()
        {
            if (filename != "")
            {
                this.Text = filename + " - Блокнот";
            }
            else
            {
                this.Text = "безымянный - Блокнот";
            }
        }
        private void Open(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            SavedUnsaved();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = ofd.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("не удалось открыть файл error");
                }
            }
            UpdateTextWithTitle();
        }
        private void Create(object sender, EventArgs e)
        {
            SavedUnsaved();
            textBox1.Text = "";
            filename = "";
            UpdateTextWithTitle();
        }
        private void Savee(string fname)
        {
            if(fname == "" && saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                filename = saveFileDialog1.FileName;
            }
            try
            {
                File.WriteAllText(filename, textBox1.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("error");
            }
        }
        private void Save(object sender, EventArgs e)
        {
            Savee(filename);
        }
        private void Print(object sender, EventArgs e)
        {
            PrintDocument pDocument = new PrintDocument();
            pDocument.PrintPage += PrintPageH;
            PrintDialog pDialog = new PrintDialog();
            pDialog.Document = pDocument;
            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                pDocument.Print();
            }
        }
        public void PrintPageH(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 0, 0);
        }
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Copyt()
        {
            Clipboard.SetText(textBox1.Text);
        }
        public void Cutt()
        {
            Clipboard.SetText(textBox1.Text);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }
        public void Pastet()
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length - textBox1.SelectionStart);
        }
        private void Copy(object sender, EventArgs e)
        {
            Copyt();
        }
        public void Cut(object sender, EventArgs e)
        {
            Cutt();
        }
        public void Paste(object sender, EventArgs e)
        {
            Pastet();
        }
        public void SavedUnsaved()
        {
            if (isFileChanged)
            {
                DialogResult = MessageBox.Show("Сохранить изменеия?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    Savee(filename);
                }
                else
                {

                }
            }
        }
        private void OnFont(object sender, EventArgs e)
        {
            fos = new FontSettings();
            fos.Show();
        }
        private void OnFocus(object sender, EventArgs e)
        {
            if(fos != null)
            {
                fontSize = fos.fontSize;
                fs = fos.fs;
                textBox1.Font = new Font(textBox1.Font.FontFamily, fontSize, fs);
                fos.Close();
            }
        }
        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия программы: 1.0\nАвтор: лиза сащикова\nДата: " + DateTime.Today.ToShortDateString(), "Информация о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
