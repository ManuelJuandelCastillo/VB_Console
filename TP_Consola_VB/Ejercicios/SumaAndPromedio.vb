Public Class SumaAndPromedio
    Public Shared Sub mostrar()
        Dim opcionSalir As Boolean = False
        Do
            Console.Clear()
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("Programa que muestra la suma y el promedio de 10 números")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("[1] Ingresar números          [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    ingresoNum()
                Case "2"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True
    End Sub

    Public Shared Sub ingresoNum()
        Console.Clear()
        Dim numeros(9) As Double
        Dim suma As Double = 0
        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine("A continuación, ingrese los 10 números")
        Console.WriteLine("-----------------------------------------------------------------")

        For i As Integer = 0 To 9
            Dim salir As Boolean
            Do
                Console.Write("Ingrese un número: ")
                Try
                    numeros(i) = Console.ReadLine()
                    salir = True
                Catch ex As Exception
                    Console.WriteLine("Valor no válido. Intente nuevamente.")
                    salir = False
                End Try
            Loop Until salir = True
            suma += numeros(i)
        Next

        Console.WriteLine("-----------------------------------------------------------------")
        Console.Write("Números ingresados: ")
        For i As Integer = 0 To 9
            Console.Write(numeros(i))
            Console.Write(" - ")
        Next
        Console.WriteLine("")
        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine($"Suma total de los 10 números: {suma}")
        Console.WriteLine($"Promedio: {suma / 10}")
        Excepcion.continuar()
    End Sub
End Class
