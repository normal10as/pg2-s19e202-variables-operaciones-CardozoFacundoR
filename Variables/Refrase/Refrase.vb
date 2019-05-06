Module Refrase

	Sub Main()
		Dim Palabra1, Palabra2 As String
		Dim frase As String = "Aunque la cadena sea de oro, sirve para lo mismo"

		Console.Write("Ingrese una palabra: ")
		Palabra1 = Console.ReadLine
		Console.Write("Ingrese otra palabra: ")
		Palabra2 = Console.ReadLine
		Console.WriteLine(Replace(frase, "la", Palabra1))
		Console.ReadKey()
	End Sub

End Module
