Imports System
'Ejercicio 1.6
Module Suma_Promedio
	Sub Main(args As String())
		Dim Numero1, Numero2, Numero3, Numero4, Suma, Resultado As Decimal
		Console.Write("Ingrese primer numero: ")
		Numero1 = Console.ReadLine
		Console.Write("Ingrese segundo numero: ")
		Numero2 = Console.ReadLine
		Console.Write("Ingrese tercer numero: ")
		Numero3 = Console.ReadLine
		Console.Write("Ingrese cuarto numero: ")
		Numero4 = Console.ReadLine

		Suma = Numero1 + Numero2 + Numero3 + Numero4
		Resultado = Suma / 4
		Console.WriteLine("La suma de los numeros ingresados es: {0}" + vbLf + "La media de la suma es: {1}", Suma, Resultado)
		Console.ReadKey()

	End Sub
End Module
