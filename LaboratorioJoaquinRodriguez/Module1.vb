Module Module1

    Sub Main()

        Dim persona As New Persona("Joaquin", "Rodrguez", 77777, "contratado", 20122012, "Masculino")

        Dim trabajador As New Trabajador("erick", "alvarado", 542244, "Contradado", 25062015, "masculino", (0.0725 * 300), (300), "Contratado")
        Dim obrero As New Obrero("alexander", "giron", 455454, "Sin Contratar", 24062020, "Masculino", 7.25, (0.73), "Contratar", 2.08, 5, 10, 44)

        Console.WriteLine("Informacion De Persona ")

        Console.WriteLine("Nombre De Persona: " & persona.propnombre)
        Console.WriteLine("apellido De Persona: " & persona.propapellido)
        Console.WriteLine("Dui De persona: " & persona.propdui)
        Console.WriteLine("Estado De persona: " & persona.proestado)
        Console.WriteLine("Fecha De Inicio De persona: " & persona.propfechainicio)
        Console.WriteLine("Sexo De Persona: " & persona.propsexo)
        Console.WriteLine("----------------------------------------------------------------------------")
        Console.WriteLine("Informacion Del Trabajador ")

        Console.WriteLine("Nombre De trabajador: " & trabajador.propnombre)
        Console.WriteLine("apellido De trabajador: " & trabajador.propapellido)
        Console.WriteLine("Dui De trabajador: " & trabajador.propdui)
        Console.WriteLine("Estado De trabajador: " & trabajador.proestado)
        Console.WriteLine("Fecha De Inicio De trabajador : " & trabajador.propfechainicio)
        Console.WriteLine("Sexo De trabajador: " & trabajador.propsexo)
        Console.WriteLine("Descuento De AFP Del trabajador: " & trabajador.Propafp)
        Console.WriteLine("Salario De trabajador: " & trabajador.Propsalario)
        Console.WriteLine("Contratar o no al trabajador: " & trabajador.Propcontratar)
        Console.WriteLine("----------------------------------------------------------------------------")
        Console.WriteLine("Informacion Del Obrero ")

        Console.WriteLine("Nombre De Obrero: " & obrero.propnombre)
        Console.WriteLine("Apellido De Obrero: " & obrero.propapellido)
        Console.WriteLine("Dui De Obrero: " & obrero.propdui)
        Console.WriteLine("Estado De Obrero: " & obrero.proestado)
        Console.WriteLine("Fecha De inicio De Obrero: " & obrero.propfechainicio)
        Console.WriteLine("Sexo Del Obrero: " & obrero.propsexo)
        Console.WriteLine("Costo Hora De Trabajo De Obrero: " & obrero.Propcostohora)
        Console.WriteLine("Costo De Hora Extra Obrero: " & obrero.Propcostohoraextra)
        Console.WriteLine("Horas Extras Del Obrero: " & obrero.Prophoraextras)
        Console.WriteLine("Horas De trabajo del obrero: " & obrero.Prophoras)



    End Sub

End Module
