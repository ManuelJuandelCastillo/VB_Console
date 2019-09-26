Public Class Rango
    Public Shared Sub rangoNumeros()

        Dim opcionSalir As Boolean = False

        Console.Clear()
        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine("Programa que comprueba si el número ingresado está entre 0 y 10")
        Console.WriteLine("-----------------------------------------------------------------")

        Do
            Console.WriteLine("")
            Console.Write("Ingrese un número entero entre 0 y 10: ")
            Try
                Dim numero As Integer = Console.ReadLine()

                If numero >= 0 And numero <= 10 Then
                    Console.WriteLine("")
                    Console.WriteLine("El número está entre 0 y 10.")
                    Console.WriteLine("Volviendo al menú principal...")
                    opcionSalir = True
                    Excepcion.continuar()
                Else
                    Console.WriteLine("")
                    Console.WriteLine("El número no está entre 0 y 10. Inténtelo nuevamente")
                End If
            Catch ex As Exception
                Console.WriteLine("")
                Console.WriteLine("No ha ingresado un número entero. Inténtelo nuevamente")
            End Try

        Loop Until opcionSalir = True
    End Sub
End Class
