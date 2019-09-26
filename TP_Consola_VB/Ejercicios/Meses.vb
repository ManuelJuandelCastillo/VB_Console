Public Class Meses
    Public Shared Sub muestraMes()

        Dim salir As Boolean = False
        Do
            Console.Clear()

            Console.WriteLine("----------------------------------------------------------------------------")
            Console.WriteLine("Programa que muestra el mes según el número elegido")
            Console.WriteLine("----------------------------------------------------------------------------")

            Console.Write("Ingrese un número de mes (y cero para salir): ")
            Dim mes As String = Console.ReadLine()

            Select Case mes
                Case "1"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elegido fue Enero")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "2"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Febrero")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "3"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Marzo")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "4"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Abril")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "5"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Mayo")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "6"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Junio")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "7"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue julio")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "8"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Agosto")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "9"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Septiembre")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "10"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Octubre")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "11"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Noviembre")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "12"
                    Console.WriteLine("")
                    Console.WriteLine("El mes elgido fue Diciembre")
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Excepcion.continuar()
                Case "0"
                    salir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until salir = True
    End Sub
End Class
