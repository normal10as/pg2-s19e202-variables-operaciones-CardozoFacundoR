Imports System.Math


Module Mayor
	Sub Main(args As String())
		Dim Numero1, Numero2, Numero3, Mayor1 As UShort
		Console.Write("Ingrese primer numero: ")
		Numero1 = Console.ReadLine
		Console.Write("Ingrese segundo numero: ")
		Numero2 = Console.ReadLine
		Console.Write("Ingrese tercer numero: ")
		Numero3 = Console.ReadLine

		Mayor1 = Max(Numero1, Numero2)

		Console.WriteLine("Los numeros ingresados son: {0} , {1} , {2} ", Numero1, Numero2, Numero3)
		Console.WriteLine("El mayor de los numeros ingresados es: " & Max(Mayor1, Numero3))
		Console.ReadKey()

	End Sub
End Module
