﻿namespace Учебная_часть
{
    partial class Otchislenie
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
            this.Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Dobav = new System.Windows.Forms.Button();
            this.Izmen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ocenki = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pricina = new System.Windows.Forms.TextBox();
            this.Gruppa = new System.Windows.Forms.TextBox();
            this.Specialnost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Data_postuplenia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kurs = new System.Windows.Forms.ComboBox();
            this.Date_otchislenia = new System.Windows.Forms.DateTimePicker();
            this.Kod_prikaza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Back.Location = new System.Drawing.Point(13, 546);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 40);
            this.Back.TabIndex = 5;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Dobav);
            this.panel2.Controls.Add(this.Izmen);
            this.panel2.Location = new System.Drawing.Point(372, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 14;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Delete.Location = new System.Drawing.Point(667, 31);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(106, 40);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Dobav
            // 
            this.Dobav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.Dobav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dobav.FlatAppearance.BorderSize = 0;
            this.Dobav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dobav.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dobav.Location = new System.Drawing.Point(533, 31);
            this.Dobav.Name = "Dobav";
            this.Dobav.Size = new System.Drawing.Size(106, 40);
            this.Dobav.TabIndex = 25;
            this.Dobav.Text = "Добавить";
            this.Dobav.UseVisualStyleBackColor = false;
            // 
            // Izmen
            // 
            this.Izmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.Izmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Izmen.FlatAppearance.BorderSize = 0;
            this.Izmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izmen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Izmen.Location = new System.Drawing.Point(404, 31);
            this.Izmen.Name = "Izmen";
            this.Izmen.Size = new System.Drawing.Size(106, 40);
            this.Izmen.TabIndex = 24;
            this.Izmen.Text = "Изменить";
            this.Izmen.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 461);
            this.dataGridView1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Ocenki);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Pricina);
            this.panel1.Controls.Add(this.Gruppa);
            this.panel1.Controls.Add(this.Specialnost);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Data_postuplenia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Kurs);
            this.panel1.Controls.Add(this.Date_otchislenia);
            this.panel1.Controls.Add(this.Kod_prikaza);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 600);
            this.panel1.TabIndex = 12;
            // 
            // Ocenki
            // 
            this.Ocenki.Location = new System.Drawing.Point(17, 179);
            this.Ocenki.Name = "Ocenki";
            this.Ocenki.Size = new System.Drawing.Size(205, 22);
            this.Ocenki.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Оценки";
            // 
            // Pricina
            // 
            this.Pricina.Location = new System.Drawing.Point(17, 123);
            this.Pricina.Name = "Pricina";
            this.Pricina.Size = new System.Drawing.Size(205, 22);
            this.Pricina.TabIndex = 24;
            // 
            // Gruppa
            // 
            this.Gruppa.Location = new System.Drawing.Point(17, 280);
            this.Gruppa.Name = "Gruppa";
            this.Gruppa.Size = new System.Drawing.Size(205, 22);
            this.Gruppa.TabIndex = 23;
            // 
            // Specialnost
            // 
            this.Specialnost.Location = new System.Drawing.Point(17, 329);
            this.Specialnost.Name = "Specialnost";
            this.Specialnost.Size = new System.Drawing.Size(205, 22);
            this.Specialnost.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Специальность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Курс";
            // 
            // Data_postuplenia
            // 
            this.Data_postuplenia.AutoSize = true;
            this.Data_postuplenia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data_postuplenia.ForeColor = System.Drawing.Color.White;
            this.Data_postuplenia.Location = new System.Drawing.Point(13, 364);
            this.Data_postuplenia.Name = "Data_postuplenia";
            this.Data_postuplenia.Size = new System.Drawing.Size(99, 19);
            this.Data_postuplenia.TabIndex = 14;
            this.Data_postuplenia.Text = "Дата приказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Причина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Код приказа";
            // 
            // Kurs
            // 
            this.Kurs.FormattingEnabled = true;
            this.Kurs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Kurs.Location = new System.Drawing.Point(17, 226);
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(205, 24);
            this.Kurs.TabIndex = 9;
            // 
            // Date_otchislenia
            // 
            this.Date_otchislenia.Location = new System.Drawing.Point(17, 386);
            this.Date_otchislenia.Name = "Date_otchislenia";
            this.Date_otchislenia.Size = new System.Drawing.Size(200, 22);
            this.Date_otchislenia.TabIndex = 8;
            // 
            // Kod_prikaza
            // 
            this.Kod_prikaza.Location = new System.Drawing.Point(17, 75);
            this.Kod_prikaza.Name = "Kod_prikaza";
            this.Kod_prikaza.Size = new System.Drawing.Size(205, 22);
            this.Kod_prikaza.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Отчисление";
            // 
            // Otchislenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Otchislenie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчисление";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Dobav;
        private System.Windows.Forms.Button Izmen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Gruppa;
        private System.Windows.Forms.TextBox Specialnost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Data_postuplenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Kurs;
        private System.Windows.Forms.DateTimePicker Date_otchislenia;
        private System.Windows.Forms.TextBox Kod_prikaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pricina;
        private System.Windows.Forms.TextBox Ocenki;
        private System.Windows.Forms.Label label4;
    }
}