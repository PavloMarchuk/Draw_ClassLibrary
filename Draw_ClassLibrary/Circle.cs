using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_ClassLibrary
	{
	public class Circle: Figure, IFigure
		{
		public Circle()
			{

			}
		public Circle(int a, int b)
			{

			}	
		public override void Draw()
			{
			Console.WriteLine("Draw() круг");
			}
		public void Display()
			{
			Console.WriteLine("Показую круг");			
			}

		public double Perimetr()
			{
			Console.WriteLine("Повертаю периметр круга");
			return 2;
			}

		public double Square()
			{
			Console.WriteLine("Повертаю площу круга");
			return 4;
			}

		public override string ToString()
			{
			return "Це круг\n\n";
			}
		}
	}
