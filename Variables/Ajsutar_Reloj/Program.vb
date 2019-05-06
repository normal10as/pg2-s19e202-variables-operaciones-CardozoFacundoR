Imports System.DateTime

Module Program
	Sub Main(args As String())

		Dim dia, hora As Byte
		Dim fecha As Date = Now
		Console.WriteLine("Ingrese un dia del 1 al 31: ")
		dia = Console.ReadLine
		Console.WriteLine("Ingrese una hora de 0 a 24:  ")
		hora = Console.ReadLine

		Console.WriteLine("Fecha y hora del ordenador: " & fecha)
		Console.WriteLine("Fecha ingresada: " & dia & "/" & fecha.Month & "/" & fecha.Year)
		Console.WriteLine("Hora ingresada: " & hora & ":" & fecha.Minute & ":" & fecha.Second)
		Console.ReadKey()
	End Sub
End Module

