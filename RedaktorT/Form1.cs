using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RedaktorT
{
    public partial class osnovkod : Form
    {
        public osnovkod()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|TR Notepad file (*.tnf)|*.tnf"; // сохранить файл в формате тескта

        }



        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;// отмена сохранения файла, возврат к программе
            string filename = saveFileDialog1.FileName; // переменная файлнейм
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("ФАЙЛ СОХРАНЕН"); 
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;// отмена открытия  файла, возврат к программе
            string filename = openFileDialog1.FileName; // переменная файлнейм
            string filetext = File.ReadAllText(filename);
            richTextBox1.Text = filetext;
            MessageBox.Show("ФАЙЛ ОТКРЫТ");
        }

        
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0) // оператор, если введен текст
            {
                richTextBox1.Copy(); // метод копировать 
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength >= 0) 
            {
                richTextBox1.Paste(); // метод копировать 
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut(); // метод вырезать
            }
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll(); // выделить все
            }
        }

        private void настроитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(); // отображает модальное диалоговое окно с выбором шрифта
            richTextBox1.Font = fontDialog1.Font;
        }

        private void настройкиФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();// отображает модальное диалоговое окно с выбором цветом фона
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // если щелчек правой мыши, то вызов контекстного меню
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0) // оператор, если введен текст
            {
                richTextBox1.Copy(); // метод копировать 
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength >= 0)
            {
                richTextBox1.Paste(); // метод вставить
            }
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut(); // метод вырезать
            }
        }

        private void выделитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll(); // выделить все
            }
        }

        private void выравниваниеПоЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Select(); // выравнивание только выделенного текста
                richTextBox1.SelectAll(); //выделение всего текста
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox1.DeselectAll(); //Отмена выделения
            }
        }

        private void выравниваниеПоПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Select(); // выравнивание только выделенного текста
                richTextBox1.SelectAll(); //выделение всего текста
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox1.DeselectAll(); //Отмена выделения
            }
        }

        private void выравниваниеПоЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Select(); // выравнивание только выделенного текста
                richTextBox1.SelectAll(); //выделение всего текста
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.DeselectAll(); //Отмена выделения
            }
        }

        private void оПрогрмаммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutRedaktor aboutRedaktor = new AboutRedaktor();
            aboutRedaktor.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
