using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notebook
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Text = "File Manager";
            /*
             Open File 
             */
            Open.Click += OpenFile_Click;
            /*
             Save File 
             */
            Save.Click += SaveFile_Click;
            
            /*
             SaveAs File 
             */
            SaveAs.Click += SaveAsFile_Click;
            /*
             FontChange
             */
            FontChange.Click += delegate 
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                string FontName = ContentTextBox.Font.Name;
                float FontSize = ContentTextBox.Font.Size;
                FontStyle fontStyle = ContentTextBox.Font.Style;
                if (form3.LocalFontFamily != null)
                {
                    FontName = form3.LocalFontFamily;
                }
                if (form3.LocalFontSize != -1)
                {
                    FontSize = form3.LocalFontSize;
                }
                if (form3.LocalFontStyle != -1)
                {
                    fontStyle = (FontStyle)form3.LocalFontStyle;
                }
                ContentTextBox.Font = new Font(FontName, FontSize, fontStyle);
            };
            /*
             FontColorChange
             */
            FontColorChange.Click += delegate
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
                string BackColor = ContentTextBox.BackColor.Name;
                string ForegroundColor = ContentTextBox.ForeColor.Name;
                if (form4.LocalBackColor != "")
                {
                    BackColor = form4.LocalBackColor;
                }
                if (form4.LocalForegroundColor != "")
                {
                    ForegroundColor = form4.LocalForegroundColor;
                }
                try
                {
                    ContentTextBox.BackColor = Color.FromName(BackColor);
                    ContentTextBox.ForeColor = Color.FromName(ForegroundColor);
                }
                catch { }
            };
            //
            // Elements Adding
            //
            Controls.AddRange(new Control[] { Open, Save, SaveAs, EnterPathLabel, PathTextBox, ContentLabel, ContentTextBox, FontChange, FontColorChange });
        }
        public string LocalContent { get { return ContentTextBox.Text; } set { ContentTextBox.Text = value; } }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT File|*.txt";
            File.WriteAllText(CurrentFile, ContentTextBox.Text);
            MessageBox.Show("Данные сохранены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void SaveAsFile_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(PathTextBox.Text, ContentTextBox.Text);
                MessageBox.Show("Данные сохранены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Данный путь недоступен.", "Ошибка записи.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Неверный путь.", "Ошибка записи.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string CurrentFile = "";
        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT File|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Save.Enabled = true;
                CurrentFile = openFileDialog.FileName;
                Text = CurrentFile;
                Form2 form2 = new Form2();
                form2.ShowDialog();
                if (form2.flag == 1) ContentTextBox.Text += File.ReadAllText(openFileDialog.FileName);
                else if (form2.flag == 2)
                {
                    ContentTextBox.Text = ContentTextBox.Text.Insert(0, File.ReadAllText(openFileDialog.FileName));
                }
                else if (form2.flag == 3)
                {
                    ContentTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        Button Open = new Button() { Text = "Открыть", Location = new System.Drawing.Point(350, 70) };
        Button Save = new Button() { Text = "Сохранить", Location = new System.Drawing.Point(350, 40), Enabled = false };
        Button SaveAs = new Button() { Text = "Сохранить как", Location = new System.Drawing.Point(350, 10), Width = 90 };
        Button FontChange = new Button() { Text = "Шрифт", Location = new Point(350, 100) };
        Button FontColorChange = new Button() { Text = "Цвет содержимого", Location = new Point(350, 130) };
        Label EnterPathLabel = new Label() { Text = "Путь для сохранения: ", Height = 15, Width = 130, Location = new Point(10, 15) };
        TextBox PathTextBox = new TextBox() { Location = new Point(140, 10) };
        Label ContentLabel = new Label() { Text = "Содержимое: ", Height = 15, Width = 150, Location = new Point(10, 50) };
        TextBox ContentTextBox = new TextBox() { Location = new Point(10, 70), Width = 330, Height = 200, Multiline = true };

        #endregion
    }
}