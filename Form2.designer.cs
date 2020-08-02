using System.Drawing;
using System.Windows.Forms;

namespace Notebook
{
    partial class Form2
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
            this.ClientSize = new System.Drawing.Size(550, 100);
            this.Text = "Выберите";

            //
            // AddEnd
            //
            AddEnd.Click += delegate { flag = 1; this.Close(); };
            //
            // AddFirst
            //
            AddFirst.Click += delegate { flag = 2; this.Close(); };
            //
            // Cancel
            //
            WriteNew.Click += delegate { flag = 3; this.Close(); };

            Cancel.Click += delegate 
            {
                if (MessageBox.Show("Вы уверены что хотите отменить действия?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                this.Close();
            };
            Controls.AddRange(new Control[] { AddEnd, AddFirst, Cancel, WriteNew });
        }

        public int flag = 0;
        Button AddEnd = new Button() { Location = new Point(10, 20), Width = 130, Text = "Добавить в конец" };
        Button AddFirst = new Button() { Location = new Point(170, 20), Width = 130, Text = "Добавить в начало" };
        Button WriteNew = new Button() { Location = new Point(330, 20), Width = 100, Text = "Заменить" };

        Button Cancel = new Button() { Location = new Point(450, 20), Text = "Отмена" };
        #endregion
    }
}