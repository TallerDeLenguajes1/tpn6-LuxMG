using System;

class MainClass {
	public static void Main () {
		int num, inverso = 0;

		Console.WriteLine("Ingrese un numero: ");
		num = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("El numero es: " + num);

		if(num>0){
			while(num>0){
				inverso = inverso * 10 + num % 10;
				num = num / 10;
			}
		}else{
			inverso = num;
		}

		Console.WriteLine("El numero invertido es: " + inverso);
	}
}