Public Class TablaMult
    Public Shared Sub muertraTabla()

        Dim numero As Integer
        Dim opcionSalir As Boolean = False
        Do
            Console.Clear()

            Console.WriteLine("-------------------------------------------------------------------")
            Console.WriteLine("Programa que muestra la tabla de multiplicar del número ingresado")
            Console.WriteLine("-------------------------------------------------------------------")
            Console.WriteLine("")
            Console.Write("Por favor, ingrese un número (y 0 para salir): ")
            Try
                numero = Console.ReadLine()

                If numero <> 0 Then
                    Console.WriteLine("")
                    Console.WriteLine($"Tabla del {numero}: ")
                    Console.WriteLine("")

                    For i As Integer = 1 To 10
                        Console.Write($"{numero} x {i} = ")
                        Console.WriteLine(numero * i)
                    Next
                Else
                    Console.WriteLine("Volviendo al menú principal...")
                    opcionSalir = True
                End If
                Excepcion.continuar()

            Catch ex As Exception
                Excepcion.valor()
            End Try
        Loop Until opcionSalir = True

    End Sub
End Class
