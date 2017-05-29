using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_ClassLibrary
	{
	public class Triangle: Figure, IFigure
		{
		public Triangle()
			{

			}
		public Triangle(int a, int b, int c)
			{

			}

		public void Display()
			{
			Console.WriteLine("Показую трикутник");
			}

		public override void Draw()
			{
			Console.WriteLine("Draw() трикутник");
			}

		public double Perimetr()
			{
			Console.WriteLine("Повертаю периметр трикутника");
			return 3;
			}

		public double Square()
			{
			Console.WriteLine("Повертаю площу трикутника");
			return 9;
			}
		}
	}
