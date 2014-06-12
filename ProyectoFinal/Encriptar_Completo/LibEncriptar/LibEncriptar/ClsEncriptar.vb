Public Class ClsEncriptar
    Function Encripta(ByVal Texto As String) As String
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Clave = "%ü&/@#$A"
        Pass2 = ""

        For i = 1 To Len(Texto)
            CAR = Mid(Texto, i, 1)
            Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Microsoft.VisualBasic.Strings.Right("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
        Next i
        Encripta = Pass2
    End Function


    Function DesEncripta(ByVal Texto As String) As String
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Dim j As Integer

        Clave = "%ü&/@#$A"
        Pass2 = ""
        j = 1
        For i = 1 To Len(Texto) Step 2
            CAR = Mid(Texto, i, 2)
            Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Chr(Asc(Codigo) Xor Val("&h" + CAR))
            j = j + 1
        Next i
        DesEncripta = Pass2
    End Function

End Class
