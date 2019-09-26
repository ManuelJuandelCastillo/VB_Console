Module Module1

    Sub Main()
        Console.ForegroundColor = ConsoleColor.White

        Dim opcionSalir As Boolean = False
        Do
            Console.Clear()

            Console.WriteLine("-----------------------------------------------------------------")
            Console.WriteLine("TP_Aplicaciones de Consola en Visual Basic")
            Console.WriteLine("Menú Principal")
            Console.WriteLine("-----------------------------------------------------------------")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [1]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Impares por Step y MOD")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("   [10]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Contar hasta...")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [2]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Saludo personalizado")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("     [11]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Suma de valores y promedio")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [3]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Mostrar mes")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("              [12]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Notas alumnos")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [4]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Calcular IVA")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("             [13]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Altura promedio")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [5]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Tablas de multiplicar")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("    [14]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Comparación de sueldos")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [6]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Divisivilidad")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("            [15]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Multiplos de 11")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [7]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Impares por While")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("        [16]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Multiplos de 8")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [8]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Impares por For")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("          [17]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Comparación de listas")

            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" [9]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write(" Identificador de rango")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("   [18]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Pares e impares")

            Console.WriteLine("")

            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(" [s]")
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(" Salir")

            Console.ForegroundColor = ConsoleColor.White

            Console.WriteLine("-----------------------------------------------------------------")
            Console.Write("Elige una Opción: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    Impares.imparesStep()
                Case "2"
                    Saludo.saludoPers()
                Case "3"
                    Meses.muestraMes()
                Case "4"
                    CalcularIVA.calcular()
                Case "5"
                    TablaMult.muertraTabla()
                Case "6"
                    Divisibilidad.dividir()
                Case "7"
                    ImparWhile.impares()
                Case "8"
                    ImparFor.impares()
                Case "9"
                    Rango.rangoNumeros()
                Case "10"
                    Contador.contarHasta()
                Case "11"
                    SumaAndPromedio.mostrar()
                Case "12"
                    NotasAlumnos.promocion()
                Case "13"
                    Estatura.promedio()
                Case "14"
                    Sueldos.evaluar()
                Case "15"
                    Tabla11.multiplos()
                Case "16"
                    Multiplos8.mostrar()
                Case "17"
                    ComparaListas.comparar()
                Case "18"
                    ParImpar.evaluar()
                Case "s"
                    opcionSalir = True
                Case Else
                    Excepcion.opcion()
            End Select

        Loop Until opcionSalir = True
    End Sub

    Sub ImparesStep()

    End Sub
End Module
