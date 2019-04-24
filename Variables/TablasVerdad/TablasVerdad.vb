Imports System

Module TablasVerdad
	Sub Main(args As String())
		Const v As Boolean = True
		Const f As Boolean = False
		'And

		Console.WriteLine("            AND      ")
		Console.WriteLine("Exp1 ~ Exp2 ~ Exp1 AND Exp2~")
		Console.WriteLine("  V  ~   V  ~    " & (v And v) & "      ~")
		Console.WriteLine("  V  ~   F  ~    " & (v And f) & "     ~")
		Console.WriteLine("  F  ~   V  ~    " & (f And v) & "     ~")
		Console.WriteLine("  F  ~   F  ~    " & (f And f) & "     ~" + vbLf)


		'Or
		Console.WriteLine("            OR      ")
		Console.WriteLine("Exp1 ~ Exp2 ~ Exp1 OR Exp2 ~")
		Console.WriteLine("  V  ~   V  ~    " & (v Or v) & "      ~")
		Console.WriteLine("  V  ~   F  ~    " & (v Or f) & "      ~")
		Console.WriteLine("  F  ~   V  ~    " & (f Or v) & "      ~")
		Console.WriteLine("  F  ~   F  ~    " & (f Or f) & "     ~" + vbLf)

		'Xor
		Console.WriteLine("            XOR      ")
		Console.WriteLine("Exp1 ~ Exp2 ~ Exp1 XOR Exp2~")
		Console.WriteLine("  V  ~   V  ~    " & (v Xor v) & "     ~")
		Console.WriteLine("  V  ~   F  ~    " & (v Xor f) & "      ~")
		Console.WriteLine("  F  ~   V  ~    " & (f Xor v) & "      ~")
		Console.WriteLine("  F  ~   F  ~    " & (f Xor f) & "     ~" + vbLf)

		'Not
		Console.WriteLine("            NOT      ")
		Console.WriteLine("Exp1 ~ NO Exp1 ~")
		Console.WriteLine("  V  ~ " & (Not v) & "   ~")
		Console.WriteLine("  F  ~ " & (Not f) & "    ~")
	End Sub
End Module
