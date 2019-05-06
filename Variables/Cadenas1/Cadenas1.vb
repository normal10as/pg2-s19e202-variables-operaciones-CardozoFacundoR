Module Cadenas1

	Sub Main()
		Dim cadena As String
		Console.Write("Ingrese una palabra: ")
		cadena = Console.ReadLine

		Console.WriteLine("La primer 'a' aparece en la pocision : " & InStr(cadena, "a"))
		Console.WriteLine("La primer 'o' aparece en la pocision : " & InStr(cadena, "o"))
		Console.WriteLine("La cadena invertida es: " & StrReverse(cadena))
		Console.ReadKey()


	End Sub

End Module
