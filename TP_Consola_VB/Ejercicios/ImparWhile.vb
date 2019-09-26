Public Class ImparWhile
    Public Shared Sub impares()
        Dim numero As Integer = 1

        While numero < 101
            If numero Mod 2 <> 0 Then
                Console.WriteLine(numero)
            End If
            numero += 1
        End While
        Excepcion.continuar()
    End Sub
End Class
