Imports System.DateTime

Module Program
	Sub Main(args As String())
		Dim fecha As Date
		Dim dias As Int16
		Console.Write("Ingrese una fecha:")
		fecha = Console.ReadLine
		Console.Write("Ingrese un numero de dias: ")
		dias = Console.ReadLine

		Console.WriteLine("Fecha ingresada: " & fecha)
		Console.WriteLine("Fecha obtenida: " & fecha.AddDays(dias))
		Console.ReadKey()


	End Sub
End Module
