# Trabajo Práctico N°6
### Ejercicio 4:
* **¿String es un tipo por valor o un tipo por referencia?**   
Tipo por referencia   
**Fuente:** [Microsoft | Docs](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/reference-types#the-string-type)

* **¿Qué secuencias de escape tiene el tipo string?**   
\ '- comilla simple    
\ "- comillas dobles   
\ \ - barra invertida    
\ 0 - nulo   
\ a - alerta   
\ b - retroceso    
\ f - alimentación de formulario   
\ n - nueva línea    
\ r - retorno de carro   
\ t - tabulacion horizontal   
\ v - tabulacion vertical   
\ u - caracter Unicode (UTF-16)    
\ U - caracter Unicode (UTF-32)   
\ x - caracter Unicode (codigo con longitud variable)    
**Fuente:** [RIPTutorial](https://riptutorial.com/es/csharp/topic/39/secuencias-de-escape-de-cadena) & [Microsoft | Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences)

* **¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?**    
La cadena se toma de forma literal, no se utilizan las secuencias de escape   
**Fuente:** [StackOverflow](https://stackoverflow.com/questions/4879152/c-sharp-before-a-string/4879186)

### Ejercicio 5:    
El término Expresiones Regulares se refiere a secuencias de caracteres que definen patrones de búsqueda, es por eso que a veces también se les conoce simplemente como patrones. -[That C# Guy](https://thatcsharpguy.com/posts/expresiones-regulares/)   
Las expresiones regulares son un lenguaje que permite simbolizar conjuntos de cadenas de texto
formadas por la concatenación de otras cadenas. Es decir, permite buscar subcadenas de texto
dentro de una cadena de texto. -[Joaquin Medina](http://joaquin.medina.name/web2008/documentos/informatica/lenguajes/puntoNET/System/Text/Regex/C_Sharp_ExpresionesRegulares.pdf)   

* **¿Funcionan únicamente en C#?**    
No    

* **¿En qué casos le parecen útiles? Enuncie al menos 3.**    
+Permiten filtrar textos para encontrar coincidencias   
+Comprobar la validez de fechas, emails, documentos de identidad o contraseñas    
+Se pueden utilizar para reemplazar texto con unas características concretas por otro   
**Fuente:** [Adictos al Trabajo](https://www.adictosaltrabajo.com/2015/01/29/regexsam/)   

* **¿Cómo se hace uso de estas en C#?**   
~No se si se refiere a~ con la clase Regex ~o a los operadores~
