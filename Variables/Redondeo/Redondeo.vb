Imports System.Math

Module Redondeo
	Sub Main(args As String())
		Dim numero As UShort
		Console.Write("Ingrese un numero: ")
		numero = Console.ReadLine

		Console.WriteLine("El valor ingresado es: " & numero)
		Console.WriteLine("Valor aproximado por exceso: " & Ceiling(numero))
		Console.WriteLine("Valor aproximado por defecto: " & Floor(numero))
		Console.WriteLine("Valor redondeado: " & Round(numero))
		Console.ReadKey()


	End Sub
End Module
