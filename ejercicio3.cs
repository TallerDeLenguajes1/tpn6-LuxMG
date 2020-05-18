using System;

class MainClass {
	public static void Main () {
		float num, num2;

		Console.Write("Ingrese un numero: ");
		num = Convert.ToSingle(Console.ReadLine());

		Console.WriteLine();
		Console.WriteLine("Valor absoluto: " + Math.Abs(num));
		Console.WriteLine("Cuadrado: " + Math.Pow(num, 2));
		Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num));
		Console.WriteLine("Seno: " + Math.Sin(num));
		Console.WriteLine("Coseno: " + Math.Cos(num));
		Console.WriteLine("Parte entera de un tipo float: " + Math.Truncate(num));

		Console.Write("\nIngrese el primer numero: ");
		num = Convert.ToSingle(Console.ReadLine());
		Console.Write("Ingrese el segundo numero: ");
		num2 = Convert.ToSingle(Console.ReadLine());

		Console.WriteLine();
		Console.WriteLine("El maximo es: " + Math.Max(num, num2));
		console.WriteLine("El minimo es: " + Math.Min(num, num2));
	}
}