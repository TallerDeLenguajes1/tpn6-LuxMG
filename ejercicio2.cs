using System;

class MainClass {
	public static void Main () {
		int continuar = 1, opcion, num1, num2, resultado;

		while(continuar == 1){
			Console.WriteLine("1. Sumar");
			Console.WriteLine("2. Restar");
			Console.WriteLine("3. Multiplicar");
			Console.WriteLine("4. Dividir");

			do{
				Console.Write("Opcion: ");
				opcion = Convert.ToInt16(Console.ReadLine());
			}while(opcion<1 || opcion>4);

			Console.Write("\nIngrese el primer numero: ");
			num1 = Convert.ToInt16(Console.ReadLine());
			Console.Write("Ingrese el segundo numero: ");
			num2 = Convert.ToInt16(Console.ReadLine());

			switch(opcion){
				case 1:
					resultado = num1 + num2;
					break;
				case 2:
					resultado = num1 - num2;
					break;
				case 3:
					resultado = num1 * num2;
					break;
				case 4:
					resultado = num1 / num2;
					break;
				default:
					resultado = 0;
					break;
			}

			Console.WriteLine("El resultado de la operacion es: " + resultado);

			Console.WriteLine("\nDesea realizar otra operacion? 1: si, 0: no");
			if(Convert.ToInt16(Console.ReadLine()) == 0){
				continuar = 0;
			}

			Console.WriteLine();
		}
	}
}