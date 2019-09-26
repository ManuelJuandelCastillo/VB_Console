Public Class NotasAlumnos
    Public Shared Sub promocion()
        Dim opcionSalir As Boolean = False
        Do
            Console.Clear()
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("Notas de alumnos")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("[1] Ingresar notas          [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    ingresoNotas()
                    Excepcion.continuar()
                Case "2"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True
    End Sub

    Public Shared Sub ingresoNotas()

        Dim notas(9) As Integer
        Dim promo As Integer = 0
        Dim noPro As Integer = 0

        Console.Clear()
        Console.WriteLine("Ingreso de notas de alumnos")
        Console.WriteLine("-----------------------------------------------------------------")

        For i As Integer = 0 To 9
            Dim reintentar As Boolean
            Do
                Console.Write($"Ingrese la nota del alumno {i + 1}: ")
                Try
                    Dim nota As Integer = Console.ReadLine()

                    If nota >= 0 And nota < 7 Then
                        noPro += 1
                        reintentar = False
                    End If

                    If nota >= 7 And nota <= 10 Then
                        promo += 1
                        reintentar = False
                    End If

                    If nota < 0 Or nota > 10 Then
                        Console.WriteLine("")
                        Console.WriteLine("Valor fuera de rango. Intente nuevamente.")
                        reintentar = True
                    End If

                Catch ex As Exception
                    Console.WriteLine("")
                    Console.WriteLine("Valor no válido. Intente nuevamente.")
                    reintentar = True
                End Try
            Loop Until reintentar = False
        Next

        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine($"Cantidad de alumnos con nota menor a 7: {noPro}")
        Console.WriteLine($"Cantidad de alumnos con nota mayor o igual a 7: {promo}")
    End Sub
End Class
