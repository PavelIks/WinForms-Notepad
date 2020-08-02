using System.Drawing;
using System.Windows.Forms;

namespace Notebook
{
    partial class Form4
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
                if (comboBoxBackColor.Text == "") LocalBackColor = "";
                if (comboBoxForegroundColor.Text == "") LocalForegroundColor = "";
            };
            //
            // BackColorLabel
            //
            this.Controls.Add(BackColorLabel);
            //
            // comboBoxFamily
            //
            for (int i = 25; i < 168; i++)
            {
                comboBoxBackColor.Items.Add(((KnownColor)i).ToString());
            }
            this.Controls.Add(comboBoxBackColor);
            //
            // ForegroundColorLabel
            //
            this.Controls.Add(ForegroundColorLabel);
            //
            // textBoxSize
            //
            this.Controls.Add(comboBoxForegroundColor);
            for (int i = 25; i < 168; i++)
            {
                comboBoxForegroundColor.Items.Add(((KnownColor)i).ToString());
            }
            //
            // SaveButton
            //
            SaveButton.Click += delegate
            {
                if (comboBoxBackColor.Text != "") LocalBackColor = comboBoxBackColor.Items[comboBoxBackColor.SelectedIndex].ToString();
                if (comboBoxForegroundColor.Text != "") LocalForegroundColor = comboBoxForegroundColor.Items[comboBoxForegroundColor.SelectedIndex].ToString();
                Close();
            };
            this.Controls.Add(SaveButton);
        }

        Label BackColorLabel = new Label() { Location = new Point(30, 30), AutoSize = true, Text = "Цвет фона" };
        ComboBox comboBoxBackColor = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(30, 50), Width = 150 };
        Label ForegroundColorLabel = new Label() { Location = new Point(230, 30), AutoSize = true, Text = "Цвет шрифта" };
        ComboBox comboBoxForegroundColor = new ComboBox() { Location = new Point(230, 50), Width = 150 };
        Button SaveButton = new Button() { Location = new Point(50, 110), Text = "Сохранить", AutoSize = true };

        #endregion
    }
}