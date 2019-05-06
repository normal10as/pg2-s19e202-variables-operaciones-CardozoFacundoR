Imports System

Module Resto_Division
	Sub main()
		Dim numero, resultado As UShort
		Console.Write("Ingrese un numero: ")
		numero = Console.ReadLine

		resultado = numero Mod 2

		Console.WriteLine("El resto de {0} dividido 2 es {1} .", numero, resultado)
		Console.ReadKey()
	End Sub
End Module
