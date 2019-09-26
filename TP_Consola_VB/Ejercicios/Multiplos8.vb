Public Class Multiplos8
    Public Shared Sub mostrar()
        Console.Clear()
        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine("Programa que muestra los multiplos de 8 hasta menores de 500")
        Console.WriteLine("-----------------------------------------------------------------")
        For i As Integer = 1 To 500
            If i Mod 8 = 0 Then
                Console.WriteLine(i)
            End If
        Next
        Excepcion.continuar()
    End Sub
End Class
