Module Module1

    Sub Main()
        Console.WriteLine("teclea el primer valor")
        Dim valor1 As Integer = CInt(Console.ReadLine)

        Console.WriteLine("teclea el segundo valor")
        Dim valor2 As Integer = CInt(Console.ReadLine)

        Console.WriteLine("La respuesta es "& valor1 * valor2 / 2)
        Console.ReadKey()



    End Sub

End Module
