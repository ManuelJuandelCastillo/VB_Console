Public Class Sueldos
    Public Shared Sub evaluar()
        Dim opcionSalir As Boolean = False

        Do
            Console.Clear()
            Console.WriteLine("Programa que evalua los sueldos de los empleados")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("[1] Ingresar sueldos         [2] Salir")
            Console.WriteLine("")
            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elija una opción: ")

            Select Case Console.ReadLine()
                Case "1"
                    ingreso()
                    Excepcion.continuar()
                Case "2"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True
    End Sub

    Public Shared Sub ingreso()
        Dim opcionSalir As Boolean = False
        Dim emp300 As Integer = 0
        Dim emp500 As Integer = 0
        Dim totalSueldos As Integer = 0

        Do
            Console.Write("Ingrese monto de sueldo: ")
            Try
                Dim sueldo As Integer = Console.ReadLine()
                If sueldo >= 100 And sueldo <= 300 Then
                    emp300 += 1
                    totalSueldos += sueldo
                End If
                If sueldo > 300 And sueldo <= 500 Then
                    emp500 += 1
                    totalSueldos += sueldo
                End If
                If sueldo < 100 Or sueldo > 500 Then
                    Console.WriteLine("Valor fuera de rango.")
                End If
            Catch ex As Exception
                Excepcion.valor()
            End Try

            Console.Write("Ingresar otro monto? (s/n): ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "s"

                Case "n"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select
        Loop Until opcionSalir = True

        Console.WriteLine("")
        Console.WriteLine("-----------------------------------------------------------------")
        Console.WriteLine($"Empleados que ganan menos de $300: {emp300}")
        Console.WriteLine($"Empleados que ganan mas de $300: {emp500}")
        Console.WriteLine("")
        Console.WriteLine($"Monto total de sueldos: {totalSueldos}")
    End Sub
End Class
