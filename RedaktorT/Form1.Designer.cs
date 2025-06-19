namespace RedaktorT
{
    partial class osnovkod
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osnovkod));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пРАВКАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шРИФТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фОНToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фОРМАТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выравниваниеПоЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выравниваниеПоПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выравниваниеПоЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПРОГАММЕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрогрмаммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1173, 571);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.пРАВКАToolStripMenuItem,
            this.шРИФТToolStripMenuItem,
            this.фОНToolStripMenuItem,
            this.фОРМАТToolStripMenuItem,
            this.оПРОГАММЕToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.открытьToolStripMenuItem.Text = "ФАЙЛ";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.открытьToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem1.BackgroundImage")));
            this.открытьToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("сохранитьКакToolStripMenuItem.BackgroundImage")));
            this.сохранитьКакToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.BackgroundImage")));
            this.сохранитьToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // пРАВКАToolStripMenuItem
            // 
            this.пРАВКАToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.пРАВКАToolStripMenuItem.Name = "пРАВКАToolStripMenuItem";
            this.пРАВКАToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.пРАВКАToolStripMenuItem.Text = "ПРАВКА";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.BackgroundImage")));
            this.копироватьToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("вставитьToolStripMenuItem.BackgroundImage")));
            this.вставитьToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.вставитьToolStripMenuItem.Text = "Вставить ";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.BackgroundImage")));
            this.вырезатьToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("выделитьВсеToolStripMenuItem.BackgroundImage")));
            this.выделитьВсеToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // шРИФТToolStripMenuItem
            // 
            this.шРИФТToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настроитьШрифтToolStripMenuItem});
            this.шРИФТToolStripMenuItem.Name = "шРИФТToolStripMenuItem";
            this.шРИФТToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.шРИФТToolStripMenuItem.Text = "ШРИФТ";
            // 
            // настроитьШрифтToolStripMenuItem
            // 
            this.настроитьШрифтToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("настроитьШрифтToolStripMenuItem.BackgroundImage")));
            this.настроитьШрифтToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.настроитьШрифтToolStripMenuItem.Name = "настроитьШрифтToolStripMenuItem";
            this.настроитьШрифтToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.настроитьШрифтToolStripMenuItem.Text = "Настроить шрифт";
            this.настроитьШрифтToolStripMenuItem.Click += new System.EventHandler(this.настроитьШрифтToolStripMenuItem_Click);
            // 
            // фОНToolStripMenuItem
            // 
            this.фОНToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиФонаToolStripMenuItem});
            this.фОНToolStripMenuItem.Name = "фОНToolStripMenuItem";
            this.фОНToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.фОНToolStripMenuItem.Text = "ФОН";
            // 
            // настройкиФонаToolStripMenuItem
            // 
            this.настройкиФонаToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("настройкиФонаToolStripMenuItem.BackgroundImage")));
            this.настройкиФонаToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.настройкиФонаToolStripMenuItem.Name = "настройкиФонаToolStripMenuItem";
            this.настройкиФонаToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.настройкиФонаToolStripMenuItem.Text = "Настройки фона";
            this.настройкиФонаToolStripMenuItem.Click += new System.EventHandler(this.настройкиФонаToolStripMenuItem_Click);
            // 
            // фОРМАТToolStripMenuItem
            // 
            this.фОРМАТToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выравниваниеПоЛевомуКраюToolStripMenuItem,
            this.выравниваниеПоПравомуКраюToolStripMenuItem,
            this.выравниваниеПоЦентруToolStripMenuItem});
            this.фОРМАТToolStripMenuItem.Name = "фОРМАТToolStripMenuItem";
            this.фОРМАТToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.фОРМАТToolStripMenuItem.Text = "ФОРМАТ ";
            // 
            // выравниваниеПоЛевомуКраюToolStripMenuItem
            // 
            this.выравниваниеПоЛевомуКраюToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("выравниваниеПоЛевомуКраюToolStripMenuItem.BackgroundImage")));
            this.выравниваниеПоЛевомуКраюToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.выравниваниеПоЛевомуКраюToolStripMenuItem.Name = "выравниваниеПоЛевомуКраюToolStripMenuItem";
            this.выравниваниеПоЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(388, 34);
            this.выравниваниеПоЛевомуКраюToolStripMenuItem.Text = "Выравнивание по левому краю";
            this.выравниваниеПоЛевомуКраюToolStripMenuItem.Click += new System.EventHandler(this.выравниваниеПоЛевомуКраюToolStripMenuItem_Click);
            // 
            // выравниваниеПоПравомуКраюToolStripMenuItem
            // 
            this.выравниваниеПоПравомуКраюToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("выравниваниеПоПравомуКраюToolStripMenuItem.BackgroundImage")));
            this.выравниваниеПоПравомуКраюToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.выравниваниеПоПравомуКраюToolStripMenuItem.Name = "выравниваниеПоПравомуКраюToolStripMenuItem";
            this.выравниваниеПоПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(388, 34);
            this.выравниваниеПоПравомуКраюToolStripMenuItem.Text = "Выравнивание по правому краю";
            this.выравниваниеПоПравомуКраюToolStripMenuItem.Click += new System.EventHandler(this.выравниваниеПоПравомуКраюToolStripMenuItem_Click);
            // 
            // выравниваниеПоЦентруToolStripMenuItem
            // 
            this.выравниваниеПоЦентруToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("выравниваниеПоЦентруToolStripMenuItem.BackgroundImage")));
            this.выравниваниеПоЦентруToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.выравниваниеПоЦентруToolStripMenuItem.Name = "выравниваниеПоЦентруToolStripMenuItem";
            this.выравниваниеПоЦентруToolStripMenuItem.Size = new System.Drawing.Size(388, 34);
            this.выравниваниеПоЦентруToolStripMenuItem.Text = "Выравнивание по центру";
            this.выравниваниеПоЦентруToolStripMenuItem.Click += new System.EventHandler(this.выравниваниеПоЦентруToolStripMenuItem_Click);
            // 
            // оПРОГАММЕToolStripMenuItem
            // 
            this.оПРОГАММЕToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрогрмаммеToolStripMenuItem});
            this.оПРОГАММЕToolStripMenuItem.Name = "оПРОГАММЕToolStripMenuItem";
            this.оПРОГАММЕToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.оПРОГАММЕToolStripMenuItem.Text = "О ПРОГАММЕ";
            // 
            // оПрогрмаммеToolStripMenuItem
            // 
            this.оПрогрмаммеToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.оПрогрмаммеToolStripMenuItem.Name = "оПрогрмаммеToolStripMenuItem";
            this.оПрогрмаммеToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.оПрогрмаммеToolStripMenuItem.Text = "О прогрмамме";
            this.оПрогрмаммеToolStripMenuItem.Click += new System.EventHandler(this.оПрогрмаммеToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1,
            this.вырезатьToolStripMenuItem1,
            this.выделитьВсеToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 132);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(193, 32);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem1_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(193, 32);
            this.вставитьToolStripMenuItem1.Text = "Вставить ";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.вставитьToolStripMenuItem1_Click);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(193, 32);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.вырезатьToolStripMenuItem1_Click);
            // 
            // выделитьВсеToolStripMenuItem1
            // 
            this.выделитьВсеToolStripMenuItem1.Name = "выделитьВсеToolStripMenuItem1";
            this.выделитьВсеToolStripMenuItem1.Size = new System.Drawing.Size(193, 32);
            this.выделитьВсеToolStripMenuItem1.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem1.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem1_Click);
            // 
            // osnovkod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 604);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "osnovkod";
            this.Text = "ТЕКСТОВЫЙ РЕДАКТОР";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пРАВКАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шРИФТToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настроитьШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фОНToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фОРМАТToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выравниваниеПоЛевомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выравниваниеПоПравомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выравниваниеПоЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПРОГАММЕToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрогрмаммеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem1;
    }
}

