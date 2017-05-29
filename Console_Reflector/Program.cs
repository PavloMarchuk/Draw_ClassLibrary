using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console_Reflector
	{
	class Program
		{
		static void Main(string[] args)
			{
			Assembly assembly = null;
			Console.WriteLine("Draw_ClassLibrary");

			
				assembly = Assembly.Load("Draw_ClassLibrary");
				Console.WriteLine("Draw_ClassLibrary - успешно загружена.");
			Console.WriteLine("==============");
			Type typeCircle = assembly.GetType("Draw_ClassLibrary.Circle", true, true);
			object objCirc = Activator.CreateInstance(typeCircle);
			MethodInfo methodCircSquare = typeCircle.GetMethod("Square");
			methodCircSquare.Invoke(objCirc, null);
			
			MethodInfo methodCircPerimetr = typeCircle.GetMethod("Perimetr");
			methodCircPerimetr.Invoke(objCirc, null);

			MethodInfo methodCircDisplay = typeCircle.GetMethod("Display");
			methodCircDisplay.Invoke(objCirc, null);

			Console.WriteLine("==============");
			Type typeTriangle = assembly.GetType("Draw_ClassLibrary.Triangle", true, true);
			object objTriangle = Activator.CreateInstance(typeTriangle);

			MethodInfo methodTriangleSquare = typeTriangle.GetMethod("Square");
			methodTriangleSquare.Invoke(objTriangle, null);

			MethodInfo methodTrianglePerimetr = typeTriangle.GetMethod("Perimetr");
			methodTrianglePerimetr.Invoke(objTriangle, null);

			MethodInfo methodTriangleDisplay = typeTriangle.GetMethod("Display");
			methodTriangleDisplay.Invoke(objTriangle, null);

			Console.WriteLine("==============");
			Type typeSquare = assembly.GetType("Draw_ClassLibrary.Square", true, true);
			object objSquare = Activator.CreateInstance(typeSquare);

			MethodInfo methodSSSPerimetr = typeSquare.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).First();
			methodSSSPerimetr.Invoke(objSquare, null);

			MethodInfo methodPerimetrPerimetr = typeSquare.GetMethod("Perimetr");
			methodPerimetrPerimetr.Invoke(objSquare, null);

			MethodInfo methodSquareDisplay = typeSquare.GetMethod("Display");
			methodSquareDisplay.Invoke(objSquare, null);


			//MethodInfo methodSquarePerimetr = typeSquare.GetMethod("Square", BindingFlags.Public |BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			//methodSquarePerimetr.Invoke(objSquare, null);
			//Console.WriteLine(methodSquarePerimetr.ToString());

			MethodInfo[] motods = typeSquare.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
			foreach(var item in motods)
				{
				Console.WriteLine(item.Name);
				}



			//========================
			//Type typeSquare = assembly.GetType("Draw_ClassLibrary.Square", true, true);
			//object objSquare = Activator.CreateInstance(typeSquare);

			//MethodInfo methodSquareSquare = typeSquare.GetMethod("Square");
			// methodSquareSquare.Invoke(objSquare, null);


			//Console.WriteLine(typeCircle);

			//object objectCircle =  assembly.CreateInstance(typeCircle.FullName, true, BindingFlags.CreateInstance, null, null, null, null);

			//object objCircle = Activator.CreateInstance(typeCircle, null);
			//MethodInfo method = typeCircle.GetMethod("Square", BindingFlags.Instance);
			//method.Invoke(objCircle, null);
			////if(objectCircle!=null)
			////	{
			////	objectCircle.

			////	}

			////CreateInstance(typeCircle.FullName, true, BindingFlags.CreateInstance, null, new object[] { }, null, null);
			////object objCircle = Activator.CreateInstance(typeCircle, new object[] { (short)50, (short)40 });



			////Type[] typeCircle2 = assembly.GetTypes();
			////foreach(var item in typeCircle2)
			////	{
			////	//object objectCircle = assembly.CreateInstance(item.FullName, true, BindingFlags.CreateInstance, null, new object[] { }, null, null);
			////	Console.WriteLine(item.FullName);
			////	//Console.WriteLine(objectCircle);
			////	}




			////MethodInfo method = typeCircle.GetMethod("Square",  BindingFlags.Instance);
			////method.Invoke(objectCircle, null);

			//Type typeTriangle = assembly.GetType("Draw_ClassLibrary.Triangle");
			//Console.WriteLine(typeTriangle);
			}
		}
	}
