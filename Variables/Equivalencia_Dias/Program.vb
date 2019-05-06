Imports System
'Ejercicio 1.7
Module Program
	Sub Main(args As String())
		Const DiasSemanas As Date = 7
		Const HorasDias As Byte = 24
		Const MinHoras As Byte = 60
		Dim Numero As Double

		Console.Write("Ingrese un numero: ")
		Numero = Console.ReadLine

		Console.WriteLine("Dias: " & DiasSemanas.AddDays(Numero))

	End Sub
End Module
