Imports System

Module Aritmetica
	Sub Main(args As String())
		Dim Entero1, Entero2 As Byte
		Dim Float1, Float2 As Single
		Dim Res1 As Decimal
		Dim Res2, Res3

		Console.Write("Ingrese un numero entero: ")
		Entero1 = Console.ReadLine
		Console.Write("Ingrese otro numero entero: ")
		Entero2 = Console.ReadLine
		Console.Write("Ingrese un numero de punto flotante: ")
		Float1 = Console.ReadLine
		Console.Write("Ingrese otro numero de punto flotante: ")
		Float2 = Console.ReadLine

		Res1 = Entero1 + Float1
		Res2 = Convert.ToDecimal(Entero1 + Float1)
		Res3 = Convert.ToDecimal(Entero2 + Float2)

		Console.WriteLine(" La suma de los enteros es: " & Entero1 + Entero2)
		Console.WriteLine(" La suma de los numeros flotantes es: " & Float1 + Float2)
		Console.WriteLine(" La suma del primer entero con el primer flotante es: {0}", Res2)
		Console.WriteLine(" La suma del segundo entero con el segundo flotante es: {0}", Res3)
		Console.ReadKey()

	End Sub
End Module
