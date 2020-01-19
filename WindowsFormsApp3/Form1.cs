using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3 {
	public partial class Form1 : Form {
		//Пикселей в одном делении оси
		const int PIX_IN_ONE = 15;
		//Длина стрелки
		const int ARR_LEN = 10;

		public Form1() {
			InitializeComponent();
			//panel2.Paint += Panel2_Paint;
		}


		private void Button2_Click(object sender, EventArgs e) {
			int res, a;
			if (Int32.TryParse(textBox1.Text, out res) && res > 0 && res < 10) {
				a = res;
			}
			else {
				MessageBox.Show("Неверное значение для параметра а." + " Введите, пожалуйста, целое число, больше 0 и меньше 10.");
				return;
			}

			Pen myPen = new Pen(Color.Blue, 1);
			Graphics g = Graphics.FromHwnd(panel2.Handle);

			//int a = 5;
			float x = -3;
			for (int i = 1; i <= 280; i += 1) {
				x += 0.1F;
				float z = (x * x * x / ((2 * a) - x));
				z = (float)Math.Sqrt(Math.Abs(z));
				float xx = x;
				xx = x + 0.1f;
				float z1 = (xx * xx * xx / ((2 * a) - xx));
				z1 = (float)Math.Sqrt(Math.Abs(z1));
				g.DrawLine(myPen, x*20 + 390, z*20+266, xx*20 + 390, z1*20+266);
				g.DrawLine(myPen, x * 20 + 390, -z * 20 + 266, xx * 20 + 390, -z1 * 20 + 266);
				System.Threading.Thread.Sleep(5);
			}

		}

		private void Button3_Click(object sender, EventArgs e) {
			Application.Restart();

		}



		//оси координат
		private void Panel2_Paint_1(object sender, PaintEventArgs e) {
			int w = panel2.ClientSize.Width / 2;
			int h = panel2.ClientSize.Height / 2;
			//Смещение начала координат в центр PictureBox
			e.Graphics.TranslateTransform(w, h);
			DrawXAxis(new Point(-w, 0), new Point(w, 0), e.Graphics);
			DrawYAxis(new Point(0, h), new Point(0, -h), e.Graphics);
			//Центр координат
			e.Graphics.FillEllipse(Brushes.Red, -2, -2, 4, 4);
		}

		//Рисование оси X
		private void DrawXAxis(Point start, Point end, Graphics g) {
			//Ось
			g.DrawLine(Pens.Black, start, end);
			//Стрелка
			g.DrawLines(Pens.Black, GetArrow(start.X, start.Y, end.X, end.Y, ARR_LEN));
		}

		//Рисование оси Y
		private void DrawYAxis(Point start, Point end, Graphics g) {
			//Ось
			g.DrawLine(Pens.Black, start, end);
			//Стрелка
			g.DrawLines(Pens.Black, GetArrow(start.X, start.Y, end.X, end.Y, ARR_LEN));
		}

		//Рисование текста
		private void DrawText(Point point, string text, Graphics g, bool isYAxis = false) {

		}

		//Вычисление стрелки оси
		private static PointF[] GetArrow(float x1, float y1, float x2, float y2, float len = 10, float width = 4) {
			PointF[] result = new PointF[3];
			//направляющий вектор отрезка
			var n = new PointF(x2 - x1, y2 - y1);
			//Длина отрезка
			var l = (float)Math.Sqrt(n.X * n.X + n.Y * n.Y);
			//Единичный вектор
			var v1 = new PointF(n.X / l, n.Y / l);
			//Длина стрелки
			n.X = x2 - v1.X * len;
			n.Y = y2 - v1.Y * len;
			result[0] = new PointF(n.X + v1.Y * width, n.Y - v1.X * width);
			result[1] = new PointF(x2, y2);
			result[2] = new PointF(n.X - v1.Y * width, n.Y + v1.X * width);
			return result;
		}

		private void Label2_Click(object sender, EventArgs e) {

		}
	}
}
