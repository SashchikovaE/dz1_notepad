namespace dz1_notepad
{
    partial class FontSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.Color = new System.Windows.Forms.ComboBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(215, 264);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(65, 16);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Образец";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleText.Location = new System.Drawing.Point(227, 280);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(230, 45);
            this.ExampleText.TabIndex = 1;
            this.ExampleText.Text = "AaBb YyZz";
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            ""});
            this.fontBox.Location = new System.Drawing.Point(31, 37);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(121, 24);
            this.fontBox.TabIndex = 2;
            this.fontBox.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // Color
            // 
            this.Color.FormattingEnabled = true;
            this.Color.Items.AddRange(new object[] {
            "чёрный",
            "жёлтый",
            "красный",
            "синий"});
            this.Color.Location = new System.Drawing.Point(455, 37);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(121, 24);
            this.Color.TabIndex = 3;
            this.Color.SelectedValueChanged += new System.EventHandler(this.OnColorChanged);
            this.Color.Click += new System.EventHandler(this.OnColorChanged);
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "жирный"});
            this.styleBox.Location = new System.Drawing.Point(235, 36);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(121, 24);
            this.styleBox.TabIndex = 4;
            this.styleBox.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "начертание";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "размер";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "цвет";
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.ExampleLabel);
            this.Name = "FontSettings";
            this.Text = "Шрифт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label ExampleText;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox Color;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}