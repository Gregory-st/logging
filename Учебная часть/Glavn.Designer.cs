namespace Учебная_часть
{
    partial class Glavn
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Slovar = new System.Windows.Forms.Button();
            this.Gruppa = new System.Windows.Forms.Button();
            this.Personal_dann = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(28, 10);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(40, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(210, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Личные дела";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.Slovar);
            this.panel1.Controls.Add(this.Gruppa);
            this.panel1.Controls.Add(this.Personal_dann);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 453);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(28, 65);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(210, 40);
            this.menuStrip2.Stretch = false;
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "Отчисление и перевод";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // Slovar
            // 
            this.Slovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Slovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Slovar.FlatAppearance.BorderSize = 0;
            this.Slovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slovar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Slovar.Location = new System.Drawing.Point(28, 236);
            this.Slovar.Name = "Slovar";
            this.Slovar.Size = new System.Drawing.Size(210, 40);
            this.Slovar.TabIndex = 6;
            this.Slovar.Text = "Словарь";
            this.Slovar.UseVisualStyleBackColor = false;
            this.Slovar.Click += new System.EventHandler(this.Slovar_Click);
            // 
            // Gruppa
            // 
            this.Gruppa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Gruppa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gruppa.FlatAppearance.BorderSize = 0;
            this.Gruppa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gruppa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Gruppa.Location = new System.Drawing.Point(28, 178);
            this.Gruppa.Name = "Gruppa";
            this.Gruppa.Size = new System.Drawing.Size(210, 40);
            this.Gruppa.TabIndex = 5;
            this.Gruppa.Text = "Группа";
            this.Gruppa.UseVisualStyleBackColor = false;
            this.Gruppa.Click += new System.EventHandler(this.Gruppa_Click);
            // 
            // Personal_dann
            // 
            this.Personal_dann.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.Personal_dann.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Personal_dann.FlatAppearance.BorderSize = 0;
            this.Personal_dann.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personal_dann.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Personal_dann.Location = new System.Drawing.Point(28, 121);
            this.Personal_dann.Name = "Personal_dann";
            this.Personal_dann.Size = new System.Drawing.Size(210, 40);
            this.Personal_dann.TabIndex = 4;
            this.Personal_dann.Text = "Персональные данные";
            this.Personal_dann.UseVisualStyleBackColor = false;
            this.Personal_dann.Click += new System.EventHandler(this.Personal_dann_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 114);
            this.label1.TabIndex = 2;
            this.label1.Text = "Приложение для работы с данными студентов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Учебная_часть.Properties.Resources.power;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Glavn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(687, 448);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Glavn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Slovar;
        private System.Windows.Forms.Button Gruppa;
        private System.Windows.Forms.Button Personal_dann;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}