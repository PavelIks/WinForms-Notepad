using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notebook
{
    partial class Form3
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
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Text = "Шрифт";
            this.FormClosed += delegate
            {
                if (comboBoxFamily.Text == "") LocalFontFamily = null;
                if (comboBoxSize.Text == "") LocalFontSize = -1;
                if (comboBoxFontStyle.Text == "") LocalFontStyle = -1;
            };
            //
            // FontFamilyLabel
            //
            this.Controls.Add(FontFamilyLabel);
            //
            // comboBoxFamily
            //
            foreach (var FontFam in FontFamily.Families)
            {
                comboBoxFamily.Items.Add(FontFam.Name);
            }
            this.Controls.Add(comboBoxFamily);
            //
            // FontSizeLabel
            //
            this.Controls.Add(FontSizeLabel);
            //
            // textBoxSize
            //
            this.Controls.Add(comboBoxSize);
            comboBoxSize.Items.AddRange(new string[] { "10", "13", "15", "18", "21", "25", "28", "30" });
            //
            // comboBoxFontStyle
            //
            this.Controls.Add(FontStyleLabel);
            comboBoxFontStyle.Items.Add("Bold");
            comboBoxFontStyle.Items.Add("Italic");
            comboBoxFontStyle.Items.Add("Regular");
            comboBoxFontStyle.Items.Add("Strikeout");
            comboBoxFontStyle.Items.Add("Underline");
            this.Controls.Add(comboBoxFontStyle);
            //
            // SaveButton
            //
            SaveButton.Click += delegate
            {
                LocalFontFamily = comboBoxFamily.Text;
                if (comboBoxSize.Text != "") LocalFontSize = Convert.ToInt32(comboBoxSize.Text);
                if (comboBoxFontStyle.Text == "") LocalFontStyle = -1;
                else
                {
                    switch (comboBoxFontStyle.Items[comboBoxFontStyle.SelectedIndex].ToString())
                    {
                        case "Bold":
                            LocalFontStyle = 1;
                            break;
                        case "Italic":
                            LocalFontStyle = 2;
                            break;
                        case "Regular":
                            LocalFontStyle = 0;
                            break;
                        case "Strikeout":
                            LocalFontStyle = 8;
                            break;
                        case "Underline":
                            LocalFontStyle = 4;
                            break;
                    }
                }
                Close();
            };
            this.Controls.Add(SaveButton);
        }

        Label FontFamilyLabel = new Label() { Location = new Point(30, 30), AutoSize = true, Text = "Название шрифта" };
        ComboBox comboBoxFamily = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(30, 50), Width = 180 };
        Label FontSizeLabel = new Label() { Location = new Point(230, 30), AutoSize = true, Text = "Размер шрифта" };
        ComboBox comboBoxSize = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(230, 50) };
        Label FontStyleLabel = new Label() { Location = new Point(30, 90), AutoSize = true, Text = "Стиль шрифта" };
        ComboBox comboBoxFontStyle = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(30, 120), Width = 100 };
        Button SaveButton = new Button() { Location = new Point(50, 150), Text = "Сохранить", AutoSize = true };

        #endregion
    }
}