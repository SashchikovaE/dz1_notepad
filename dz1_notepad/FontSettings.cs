using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dz1_notepad
{
    public partial class FontSettings : Form
    {
        public int fontSize = 0;
        public FontStyle fs = FontStyle.Regular;
        public Color c = System.Drawing.Color.Black;

        public FontSettings()
        {
            InitializeComponent();
            fontBox.SelectedItem = fontBox.Items[0];
            styleBox.SelectedItem = styleBox.Items[0];
        }
        private void OnFontChanged(object sender, EventArgs e)
        {
            ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString())); 
            fontSize = int.Parse(fontBox.SelectedItem.ToString());
        }

        private void OnStyleChanged(object sender, EventArgs e)
        {
            switch (styleBox.SelectedItem.ToString())
            {
                case "обычный":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Regular);
                    break;
                case "курсив":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Italic);
                    break;
                case "жирный":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Bold);
                    break;
            }
            fs = ExampleText.Font.Style;
        }
        private void OnColorChanged(object sender, EventArgs e)
        {
            switch (Color.SelectedItem?.ToString())
            {
                case "чёрный":
                    textBox1.ForeColor = System.Drawing.Color.Black;
                    break;
                case "красный":
                    textBox1.ForeColor = System.Drawing.Color.Red;
                    break;
                case "жёлтый":
                    textBox1.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case "синий":
                    textBox1.ForeColor = System.Drawing.Color.Blue;
                    break;
            }
            c = ExampleText.ForeColor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
