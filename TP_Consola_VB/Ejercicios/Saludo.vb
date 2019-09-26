Public Class Saludo
    Public Shared Sub saludoPers()
        Console.Clear()
        Console.WriteLine("----------------------------------------------------------------------------")
        Console.WriteLine("Programa que realiza un saludo personalizado")
        Console.WriteLine("----------------------------------------------------------------------------")
        Console.Write("Ingrese su nombre, por favor: ")
        Dim nombre As String = Console.ReadLine()

        Console.WriteLine("----------------------------------------------------------------------------")
        Console.WriteLine("")
        Console.WriteLine($"Hola {nombre}! Bienvendo!")
        Console.WriteLine("")
        Console.WriteLine("----------------------------------------------------------------------------")
        Console.Write("Presione una tecla para volver al menú principal...")
        Console.ReadKey()
    End Sub
End Class
