Public Class CalcularIVA
    Public Shared Sub calcular()
        Dim opcionSalir As Boolean = False   'flag para salir del bucle do while
        Do
            Console.Clear()

            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("Programa que calcula IVA y muestra precio final")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("[1] Calcular IVA          [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")

            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    Console.WriteLine("")
                    Console.Write("Ingrese el valor del producto: ")

                    Try
                        Dim precioSinIva As Double = Console.ReadLine()

                        Dim valorIVA As Double = precioSinIva * 0.21
                        Dim precioFinal As Double = precioSinIva + valorIVA

                        Console.WriteLine("")
                        Console.WriteLine($"Valor inicial: $ {precioSinIva}")
                        Console.WriteLine($"Valor IVA: $ {valorIVA}")
                        Console.WriteLine($"Valor final: $ {precioFinal}")
                        Console.WriteLine("-----------------------------------------------------------------")
                        Excepcion.continuar()

                    Catch
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
