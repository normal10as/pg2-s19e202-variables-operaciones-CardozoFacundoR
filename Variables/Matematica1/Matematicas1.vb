Imports System.Math

Module Matematicas1
	Sub Main(args As String())
		Dim numero As UShort
		Console.Write("Ingrese un numero: ")
		numero = Console.ReadLine

		Console.WriteLine("Numero ingresado: {0}", numero)
		Console.WriteLine("Valor absoluto : {0}", Abs(numero))
		Console.WriteLine("Elevado a la decima potencia : {0}", Pow(numero, 10))
		Console.WriteLine("Raiz cuadrada: {0}", Sqrt(numero))
		Console.ReadKey()
	End Sub
End Module
