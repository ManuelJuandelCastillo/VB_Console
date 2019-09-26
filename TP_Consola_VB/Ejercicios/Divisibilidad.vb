Public Class Divisibilidad
    Public Shared Sub dividir()

        Dim opcionSalir As Boolean = False
        Do
            Console.Clear()

            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("Programa que verifica si un primer número es divisible por otro")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine(" [1] Verificar divisibilidad      [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    Console.WriteLine("-----------------------------------------------------------------")
                    Console.WriteLine("")
                    Console.Write("Ingrese el número a dividir: ")
                    Try
                        Dim dividendo As Integer = Console.ReadLine()
                        Console.WriteLine("")
                        Console.Write("Ingrese el divisor: ")

                        Try
                            Dim divisor As Integer = Console.ReadLine()

                            If dividendo Mod divisor = 0 Then
                                Console.WriteLine("")
                                Console.WriteLine($"{dividendo} es divisible por {divisor}")
                                Excepcion.continuar()
                            Else
                                Console.WriteLine("")
                                Console.WriteLine($"{dividendo} no es divisible por {divisor}")
                                Excepcion.continuar()
                            End If
                        Catch ex As Exception
                            Excepcion.valor()
                        End Try

                    Catch ex As Exception
                        Excepcion.valor()
                    End Try

                Case "2"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True

    End Sub
End Class
