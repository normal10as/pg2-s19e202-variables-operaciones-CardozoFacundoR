Imports System

Module Semanas
	Sub Main(args As String())
		Const DiasA�o As UShort = 364
		Const DiasSem As Byte = 7
		Const DiasLab As Byte = 5
		Dim SemA�o, SemLab As Int16

		SemA�o = DiasA�o / DiasSem
		SemLab = (SemA�o * DiasLab) / DiasSem

		Console.WriteLine("El a�o tiene {0} semanas.", SemA�o)
		Console.WriteLine("El a�o tiene {0} semanas laborables.", SemLab)
		Console.ReadKey()


	End Sub
End Module
