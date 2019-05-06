Imports System.DateTime

Module Reloj
	Sub Main(args As String())
		Dim hoy As DateTime = Now
		Console.WriteLine("Dia del ano:" & hoy.DayOfYear)
		Console.WriteLine("Mes del ano:" & hoy.Month)
		Console.WriteLine("Hora: " & hoy.Hour)
		Console.WriteLine("Minutos: " & hoy.Minute)
		Console.WriteLine("Segundos: " & hoy.Second)
		Console.ReadKey()
	End Sub
End Module
