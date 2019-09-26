Public Class ParImpar
    Public Shared Sub evaluar()
        Dim opcionSalir As Boolean = False
        Do
            Console.Clear()
            Console.WriteLine("Programa que cuenta los números pares e impares ingresados")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("[1] Ingresar números       [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    ingresarNumeros()
                    Excepcion.continuar()
                Case "2"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True
    End Sub

    Public Shared Sub ingresarNumeros()
        Dim opcionSalir As Boolean = False
        Dim pares As Integer = 0
        Dim impares As Integer = 0

        Console.Clear()
        Console.WriteLine("Ingreso de números a evaluar")
        Console.WriteLine("-----------------------------------------------------------------")
        Do
            Console.Write(vbCr + "Ingrese un número entero: ")

            Try
                Dim numero As Integer = Console.ReadLine()
                If numero Mod 2 = 0 Then
                    pares += 1

                Else impares += 1
                End If
            Catch ex As Exception
                Console.WriteLine("Valor fuera de rango.")
            End Try
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("[1] Ingresar otro número       [2] Evaluar")
            Console.WriteLine("")
            Console.Write("elija una opción: ")
            Dim opcion As String = Console.ReadLine()
            Select Case opcion
                Case "1"

                Case "2"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True

        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine($"Cantidad de números pares ingresados: {pares}")
        Console.WriteLine($"Cantidad de números impares ingresados: {impares}")
    End Sub
End Class
