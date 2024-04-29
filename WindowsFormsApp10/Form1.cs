using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем введенные данные
            string name = textBoxName.Text;
            int x = int.Parse(textBoxX.Text);
            int y = int.Parse(textBoxY.Text);

            // Получаем объект Graphics для формы
            Graphics g = this.CreateGraphics();

            // Создаем кисть для красного цвета и кисть для черного цвета
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black);

            // Размеры прямоугольника, в котором будет нарисован текст
            int width = 200;
            int height = 100;

            // Отрисовка черного прямоугольника
            g.FillRectangle(blackBrush, x, y, width, height);

            // Отрисовка имени красным цветом внутри прямоугольника
            g.DrawString(name, this.Font, redBrush, x + 10, y + 10);

            // Освобождаем ресурсы
            redBrush.Dispose();
            blackBrush.Dispose();
            blackPen.Dispose();
            g.Dispose();
        }
    }
}
