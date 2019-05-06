Imports System
'Ejercicio 1.9
Module Interes
	Sub Main(args As String())
		Dim IntProd
		Dim Monto, Interes, tiempo

		Console.Write("Ingresar monto: ")
		Monto = Console.ReadLine
		Console.Write("Ingresar interes: ")
		Interes = Console.ReadLine
		Console.Write("Ingresar tiempo: ")
		tiempo = Console.ReadLine

		IntProd = (Monto * Interes * tiempo) / (360 * 100)
		Console.WriteLine("El interes producido de ${0} en {1} dias a un {2}% es igual a {3} ",
						  Monto, tiempo, Interes, IntProd)
		Console.ReadKey()
	End Sub
End Module
