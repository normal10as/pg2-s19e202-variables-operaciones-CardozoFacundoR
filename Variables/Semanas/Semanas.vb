Imports System

Module Semanas
	Sub Main(args As String())
		Const DiasAño As UShort = 364
		Const DiasSem As Byte = 7
		Const DiasLab As Byte = 5
		Dim SemAño, SemLab As Int16

		SemAño = DiasAño / DiasSem
		SemLab = (SemAño * DiasLab) / DiasSem

		Console.WriteLine("El año tiene {0} semanas.", SemAño)
		Console.WriteLine("El año tiene {0} semanas laborables.", SemLab)
		Console.ReadKey()


	End Sub
End Module
