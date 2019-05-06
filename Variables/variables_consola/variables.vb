Imports System
'Ejercicio 1.1
Module variables
	Sub Main()
		Dim Nombre As String
		Dim Apellido
		Dim FechaNac As DateTime 

		Console.Write("Ingrese el nombre: ")
		Nombre = Console.ReadLine
		Console.Write("Ingrese el apellido: ")
		Apellido = Console.ReadLine
		Console.Write("Ingrese la Fecha de Nacimiento: ")
		FechaNac = Console.ReadLine

		Console.Write(Nombre & Apellido & " nacio el " & FechaNac)
		Console.ReadKey()
	End Sub
End Module
