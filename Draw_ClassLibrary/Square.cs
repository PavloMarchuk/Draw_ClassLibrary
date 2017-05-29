using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_ClassLibrary
	{
	public class Square: Figure, IFigure
		{
		public Square()
			{

			}
		//public Square(int a, int b, int c, int d)
		//	{

		//	}
		public void Display()
			{
			Console.WriteLine("Показую квадрат");
			}

		public override void Draw()
			{
			Console.WriteLine("Draw() квадрат");
			}

		public double Perimetr()
			{
			Console.WriteLine("Повертаю периметр квадрата");
			return 4;
			}


		 double IFigure.Square()
			{
			Console.WriteLine("Повертаю площу квадрата");
			return 16;
			}
		}
	}


