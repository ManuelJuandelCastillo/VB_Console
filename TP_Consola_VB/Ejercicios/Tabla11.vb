Public Class Tabla11
    Public Shared Sub multiplos()
        Console.Clear()
        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine("Programa que muestra los primeros 25 multiplos de 11")
        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine("")
        For i As Integer = 1 To 25
            Console.WriteLine($" 11 x {i} = {i * 11}")
        Next
        Excepcion.continuar()
    End Sub
End Class
