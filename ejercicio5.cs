using System;

class MainClass {
	public static void Main () {
		int continuar = 1;
		string patternweb = @"\A(https://|http://)?\w+(\.\w+)*(\.\w{2,4})+\Z";
								//https:// cualquiertexto .extras .dominios
								//como el www no se utiliza mucho actualmente,
								//decidi no ponerlo como obligatorio
		string patternmail = @"\A(\w+\.?\w*)+(\@\w+)(\.\w{2,4})+\Z";	
								//mucho.texto @ texto .dominios
		string cadena = String.Empty;

		System.Text.RegularExpressions.Regex email = new System.Text.RegularExpressions.Regex(patternmail);
		System.Text.RegularExpressions.Regex web = new System.Text.RegularExpressions.Regex(patternweb);

		do{
			Console.WriteLine("Ingrese una direccion web: ");
			cadena = Console.ReadLine();

			if(web.IsMatch(cadena)){
				Console.WriteLine("Direccion valida");
				continuar = 0;
			}else{
				Console.WriteLine("Direccion invalida");
			}

			Console.WriteLine("\nDesea intentar con otra? 0:no, 1:si");
			do{
				continuar = Convert.ToInt16(Console.ReadLine());
			}while(continuar<0 || continuar>1);
			Console.WriteLine();

		}while(continuar!=0);

		Console.WriteLine();
		continuar = 1;

		do{
			Console.WriteLine("Ingrese un email: ");
			cadena = Console.ReadLine();

			if(email.IsMatch(cadena)){
				Console.WriteLine("Mail valido");
				continuar = 0;
			}else{
				Console.WriteLine("Mail invalido");
			}

			Console.WriteLine("\nDesea intentar con otra? 0:no, 1:si");
			do{
				continuar = Convert.ToInt16(Console.ReadLine());
			}while(continuar<0 || continuar>1);
			Console.WriteLine();

		}while(continuar!=0);
	}
}