Public Class Contador
    Public Shared Sub contarHasta()
        Dim opcionSalir As Boolean = False
        Do
            Console.Clear()
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("Programa que muestra los números desde 1 hasta el valor ingresado")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("[1] Ingresar número            [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    Console.WriteLine("")
                    Console.Write("Ingrese un número entero positivo: ")
                    Try
                        Dim numero As Integer = Console.ReadLine()
                        For i As Integer = 1 To numero
                            Console.WriteLine(i)
                        Next
                        Excepcion.continuar()
                    Catch ex As Exception
                        Excepcion.valor()
                    End Try
                Case 2
                    Exit Sub
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True
    End Sub
End Class
