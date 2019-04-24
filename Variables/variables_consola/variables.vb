Imports System

Module variables
	Sub Main()
		Dim Nombre As String = "Facundo "
		Dim Apellido = "Cardozo "
		Dim FechaNac As DateTime = (#1995-7-18#)

		Console.Write(Nombre & Apellido & " nacio el " & FechaNac)
		Console.ReadKey()
	End Sub
End Module
