Public Class ComparaListas
    Public Shared Sub comparar()
        Dim opcionSalir As Boolean = False

        Do
            Console.Clear()
            Console.WriteLine("Programa que compara 2 listas de 15 números c/u")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("[1] Ingresar listas      [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    ComparaListas()
                    Excepcion.continuar()
                Case "2"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True
    End Sub

    Public Shared Sub comparaListas()
        Dim lista1 As Integer = 0
        Dim lista2 As Integer = 0

        'ingreso de numeros de la lista 1
        Console.Clear()
        Console.WriteLine("Ingrese los valores de la lista 1")
        Console.WriteLine("-----------------------------------------------------------------")
        For i As Integer = 1 To 15
            Dim reintentar As Boolean = True
            Do
                Console.WriteLine("")
                Console.Write($"Ingrese el valor {i} de la lista 1: ")
                Try
                    lista1 += Console.ReadLine()
                    reintentar = False
                Catch ex As Exception
                    Excepcion.valor()
                End Try
            Loop Until reintentar = False
        Next
        Console.Write("Lista 1 completa.")
        Excepcion.continuar()

        'ingreso de numeros de la lista 2
        Console.Clear()
        Console.WriteLine("Ingrese los valores de la lista 2")
        Console.WriteLine("-----------------------------------------------------------------")
        For i As Integer = 1 To 15
            Dim reintentar As Boolean = True
            Do
                Console.WriteLine("")
                Console.Write($"Ingrese el valor {i} de la lista 2: ")
                Try
                    lista2 += Console.ReadLine()
                    reintentar = False
                Catch ex As Exception
                    Excepcion.valor()
                End Try
            Loop Until reintentar = False
        Next
        Console.Write("Lista 1 completa.")
        Excepcion.continuar()

        Console.WriteLine("-----------------------------------------------------------------")
        If lista1 > lista2 Then
            Console.WriteLine("Lista 1 mayor")
        End If
        If lista1 = lista2 Then
            Console.WriteLine("Listas iguales")
        End If
        If lista2 > lista1 Then
            Console.WriteLine("Lista 2 mayor")
        End If
    End Sub
End Class
