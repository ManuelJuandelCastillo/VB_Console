Public Class Impares
    Public Shared Sub imparesStep()

        Console.Clear()

        Console.WriteLine("----------------------------------------------------------------------------")
        Console.WriteLine("Programa que muestra los números impares entre 1 y 10 usando el método STEP")
        Console.WriteLine("----------------------------------------------------------------------------")
        For i As Integer = 1 To 10 Step 2
            Console.WriteLine(i)
        Next
        Console.WriteLine("----------------------------------------------------------------------------")
        Console.WriteLine("Programa que muestra los números impares entre 1 y 10 usando el método MOD")
        Console.WriteLine("----------------------------------------------------------------------------")
        For i As Integer = 1 To 10
            If i Mod 2 <> 0 Then
                Console.WriteLine(i)
            End If
        Next
        Console.WriteLine("----------------------------------------------------------------------------")
        Console.Write("Presione una tecla para volver al menú principal...")
        Console.ReadKey()
    End Sub
End Class
