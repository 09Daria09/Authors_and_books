namespace Authors_and_books
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАвтораToolStripMenuItem,
            this.удалитьАвтораToolStripMenuItem,
            this.редактироватьАвтораToolStripMenuItem,
            this.добавитьКToolStripMenuItem,
            this.удалитьКнигуToolStripMenuItem,
            this.редактироватьКнигуToolStripMenuItem});
            this.опцииToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // добавитьАвтораToolStripMenuItem
            // 
            this.добавитьАвтораToolStripMenuItem.Name = "добавитьАвтораToolStripMenuItem";
            this.добавитьАвтораToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.добавитьАвтораToolStripMenuItem.Text = "Добавить автора";
            this.добавитьАвтораToolStripMenuItem.Click += new System.EventHandler(this.добавитьАвтораToolStripMenuItem_Click);
            // 
            // удалитьАвтораToolStripMenuItem
            // 
            this.удалитьАвтораToolStripMenuItem.Name = "удалитьАвтораToolStripMenuItem";
            this.удалитьАвтораToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.удалитьАвтораToolStripMenuItem.Text = "Удалить автора";
            this.удалитьАвтораToolStripMenuItem.Click += new System.EventHandler(this.удалитьАвтораToolStripMenuItem_Click);
            // 
            // редактироватьАвтораToolStripMenuItem
            // 
            this.редактироватьАвтораToolStripMenuItem.Name = "редактироватьАвтораToolStripMenuItem";
            this.редактироватьАвтораToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.редактироватьАвтораToolStripMenuItem.Text = "Редактировать автора";
            this.редактироватьАвтораToolStripMenuItem.Click += new System.EventHandler(this.редактироватьАвтораToolStripMenuItem_Click);
            // 
            // добавитьКToolStripMenuItem
            // 
            this.добавитьКToolStripMenuItem.Name = "добавитьКToolStripMenuItem";
            this.добавитьКToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.добавитьКToolStripMenuItem.Text = "Добавить книгу";
            this.добавитьКToolStripMenuItem.Click += new System.EventHandler(this.добавитьКToolStripMenuItem_Click);
            // 
            // удалитьКнигуToolStripMenuItem
            // 
            this.удалитьКнигуToolStripMenuItem.Name = "удалитьКнигуToolStripMenuItem";
            this.удалитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.удалитьКнигуToolStripMenuItem.Text = "Удалить книгу";
            this.удалитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.удалитьКнигуToolStripMenuItem_Click);
            // 
            // редактироватьКнигуToolStripMenuItem
            // 
            this.редактироватьКнигуToolStripMenuItem.Name = "редактироватьКнигуToolStripMenuItem";
            this.редактироватьКнигуToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.редактироватьКнигуToolStripMenuItem.Text = "Редактировать книгу";
            this.редактироватьКнигуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьКнигуToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(799, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(799, 354);
            this.listBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(320, 440);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Фильтрация";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 489);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Авторы и книги";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКнигуToolStripMenuItem;
    }
}

