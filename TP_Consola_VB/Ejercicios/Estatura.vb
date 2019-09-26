Public Class Estatura
    Public Shared Sub promedio()
        Dim opcionSalir As Boolean = False

        Do
            Console.Clear()
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("Programa para calcular la estatura proedio de n personas")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("[1] Ingresar estaturas       [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    ingresarAltura()
                    Excepcion.continuar()
                Case "2"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True
    End Sub

    Public Shared Sub ingresarAltura()
        Dim sumaAlturas As Double = 0
        Dim contador As Integer = 0
        Dim salir As Boolean = False
        Console.Clear()
        Console.WriteLine("Ingrese las estaturas en cm")
        Console.WriteLine("-----------------------------------------------------------------")

        Do
            Console.WriteLine("")
            Console.Write("Ingrese la estatura en cm: ")
            Try
                sumaAlturas += Console.ReadLine()
                contador += 1
            Catch ex As Exception
                Excepcion.valor()
            End Try

            Dim reintentar As Boolean = False
            Do
                reintentar = False
                Console.WriteLine("")
                Console.Write("Desea ingresar otra altura?(s/n)")
                Dim opcion As String = Console.ReadLine()

                Select Case opcion
                    Case "s"

                    Case "n"
                        salir = True
                    Case Else
                        Console.WriteLine("Opción no válida.")
                        reintentar = True
                End Select
            Loop Until reintentar = False
        Loop Until salir = True

        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine($"La altura promedio es {sumaAlturas / contador}")
    End Sub
End Class
