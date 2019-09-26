Public Class ImparFor
    Public Shared Sub impares()
        For numero As Integer = 1 To 100
            If numero Mod 2 <> 0 Then
                Console.WriteLine(numero)
            End If
        Next
        Excepcion.continuar()
    End Sub
End Class
