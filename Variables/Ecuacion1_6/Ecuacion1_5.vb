Imports System

Module Ecuacion1_5
	Sub Main(args As String())
		Dim x As Decimal
		Dim a, b, c As Byte
		a = 1
		b = 5
		c = 2
		x = (b ^ 2 - 4 * a * c) / (2 * a)

		Console.WriteLine("El resultado de x es: {0}", x)
		Console.ReadKey()

	End Sub
End Module
