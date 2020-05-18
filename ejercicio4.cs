using System;

class MainClass {
	public static void Main () {
		int continuar = 1, opcion;

		while(continuar==1){
			Menu();

			do{
				Console.Write("Opcion: ");
				opcion = Convert.ToInt16(Console.ReadLine());
			}while(opcion<1 || opcion>11);

			Console.WriteLine();
			Opciones(opcion);

			Console.WriteLine("\nDesea realizar otra operacion? 1: si, 0: no");
			if(Convert.ToInt16(Console.ReadLine()) == 0){
				continuar = 0;
			}

			Console.WriteLine("\n/***********************************************************/\n");
		}
	}

	public static void Menu (){
		Console.WriteLine("1. Ver algunas letras de la cadena");
		Console.WriteLine("2. Ver la longitud de la cadena");
		Console.WriteLine("3. Concatenar dos cadenas");
		Console.WriteLine("4. Extraer una subcadena");
		Console.WriteLine("5. Usar la calculadora");
		Console.WriteLine("6. Recorrer la cadena con un foreach");
		Console.WriteLine("7. Buscar una palabra");
		Console.WriteLine("8. Convertir la cadena a mayusculas y minusculas");
		Console.WriteLine("9. Comparar los valores de dos cadenas");
		Console.WriteLine("10. Separar una cadena en array (split)");
		Console.WriteLine("11. Usar calculadora con cadenas de caracteres");
	}

	public static void Opciones(int opcion){
		int aux, num1, num2, resultado;
		string palabra, cadena2, cadena1 = String.Empty;
		string[] arreglo;
		char car;
		string pattern = @"(\d+)+([-+*/])+(\d+)";

		if(opcion!=5 && opcion!=11){
			Console.WriteLine("Ingrese una cadena de texto: ");
			cadena1 = Console.ReadLine();
		}

		switch(opcion){
			case 1: //letras que forman parte de la cadena
				Console.WriteLine("Algunas letras que forman parte de la cadena son: ");
				Console.WriteLine(cadena1[1] + " " + cadena1[3] + " " + cadena1[7]);
				break;

			case 2: //longitud de la cadena
				Console.WriteLine("Longitud de la cadena: " + cadena1.Length);
				break;

			case 3: //concatenar dos cadenas
				Console.WriteLine("Ingrese otra cadena de texto: ");
				cadena2 = Console.ReadLine();
				Console.WriteLine("Cadenas concatenadas: " + string.Concat(cadena1, cadena2));
				break;

			case 4: //subcadena
				do{
					Console.Write("Ingrese un numero: ");
					aux = Convert.ToInt16(Console.ReadLine());
				}while(aux<0 || aux>cadena1.Length);
				Console.WriteLine("Subcadena extraida: " + cadena1.Substring(aux));
				break;

			case 5: //calculadora que convierte a texto los resultados
				Console.WriteLine("1. Sumar");
				Console.WriteLine("2. Restar");
				Console.WriteLine("3. Multiplicar");
				Console.WriteLine("4. Dividir");

				do{
					Console.Write("Opcion: ");
					aux = Convert.ToInt16(Console.ReadLine());
				}while(aux<1 || aux>4);

				Console.Write("\nIngrese el primer numero: ");
				num1 = Convert.ToInt16(Console.ReadLine());
				Console.Write("Ingrese el segundo numero: ");
				num2 = Convert.ToInt16(Console.ReadLine());

				switch(aux){
					case 1:
						resultado = num1 + num2;
						Console.WriteLine("La suma entre " + num1.ToString() + " y " + num2.ToString() + " es: " + resultado.ToString());
						break;
					case 2:
						resultado = num1 - num2;
						Console.WriteLine("La resta entre " + num1.ToString() + " y " + num2.ToString() + " es: " + resultado.ToString());
						break;
					case 3:
						resultado = num1 * num2;
						Console.WriteLine("La multiplicacion entre " + num1.ToString() + " y " + num2.ToString() + " es: " + resultado.ToString());
						break;
					case 4:
						resultado = num1 / num2;
						Console.WriteLine("La division entre " + num1.ToString() + " y " + num2.ToString() + " es: " + resultado.ToString());
						break;
					default:
						Console.WriteLine("La operacion no pudo realizarse, intente poner los numeros y el operador juntos, sin espacios");
						break;
				}
				break;

			case 6: //mostrar la cadena con un foreach
				Console.WriteLine("Recorriendo la cadena caracter a caracter con un foreach: ");
				foreach(char caracter in cadena1){
					Console.Write(caracter + "\t");
				}
				Console.WriteLine();
				break;

			case 7: //buscar una palabra
				Console.Write("Ingrese una palabra a buscar: ");
				palabra = Console.ReadLine();
				if(cadena1.Contains(palabra)){
					Console.WriteLine("La cadena contiene la palabra '" + palabra + "'");
				}else{
					Console.WriteLine("La cadena no contiene la palabra '" + palabra + "'");
				}
				break;

			case 8: //convertir a mayusculas y minusculas
				Console.WriteLine("Cadena en mayusculas: " + cadena1.ToUpper());
				Console.WriteLine("Cadena en minusculas: " + cadena1.ToLower());
				break;

			case 9: //comparar los valores de dos cadenas
				Console.WriteLine("Ingrese otra cadena de texto: ");
				cadena2 = Console.ReadLine();
				if(string.Compare(cadena1, cadena2) == 0){
					Console.WriteLine("Ambas cadenas son iguales");
				}else{
					if(string.Compare(cadena1, cadena2) > 0){
						Console.WriteLine("La cadena '" + cadena1 + "' es mayor a la cadena '" + cadena2 + "'");
					}else{
						Console.WriteLine("La cadena '" + cadena1 + "' es menor a la cadena '" + cadena2 + "'");
					}
				}
				break;

			case 10: //separar una cadena con split
				Console.Write("Ingrese un caracter: ");
				car = Convert.ToChar(Console.ReadLine());
				arreglo = cadena1.Split(car.ToString());
				foreach(string cad in arreglo){
					Console.WriteLine(cad);
				}
				break;

			case 11: //calculadora con cadenas de caracteres //basado en un ejemplo de Microsoft Docs
				Console.WriteLine("Ingrese la operacion que desea realizar: ");
				cadena2 = Console.ReadLine();
				foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(cadena2, pattern)){
					int value1 = Int32.Parse(m.Groups[1].Value);
					int value2 = Int32.Parse(m.Groups[3].Value);
					switch (m.Groups[2].Value)
					{
						case "+":
							Console.WriteLine("{0} = {1}", m.Value, value1 + value2);
							break;
						case "-":
							Console.WriteLine("{0} = {1}", m.Value, value1 - value2);
							break;
						case "*":
							Console.WriteLine("{0} = {1}", m.Value, value1 * value2);
							break;
						case "/":
							Console.WriteLine("{0} = {1:N2}", m.Value, value1 / value2);
							break;
					}
				}
				break;

			default: break;
		}
	}
}