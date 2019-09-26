Public Class Excepcion
    Public Shared Sub opcion()
        Console.WriteLine("")
        Console.Write("Opción no válida. Presione una tecla para continuar...")
        Console.ReadKey()
        Console.WriteLine("")
    End Sub

    Public Shared Sub valor()
        Console.WriteLine("")
        Console.Write("Valor no válido. Presione una tecla para continuar...")
        Console.ReadKey()
        Console.WriteLine("")
    End Sub

    Public Shared Sub continuar()
        Console.WriteLine("")
        Console.Write("Presione una tecla para continuar...")
        Console.ReadKey()
    End Sub
End Class
