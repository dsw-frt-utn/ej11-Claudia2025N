using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{



    
    
    
    public static void EjemploList()
    {
        Console.WriteLine("******************PRUEBA DEL CASO LIST******************");
        CasoList casoList = new CasoList();

        //Agregar 3 alumnos a la lista
        Alumno alumno1 = new Alumno(123, "Juan Ramirez", 7.1);
        Alumno alumno2 = new Alumno(456, "Rosa Perez", 8.2);
        Alumno alumno3 = new Alumno(789, "Sofia Retamozo", 6.5);
        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        //Listar por consola los alumnos
        Console.WriteLine("             Lista de alumnos             \n");
        foreach (var alumno in casoList.ObtenerList()) { Console.WriteLine($"Alumno:{alumno}\n"); }


        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine($"      1)Busqueda del alumno:{alumno3.Nombre}");
        Alumno encontrado = casoList.BuscarPorNombre(alumno3.Nombre);
        Console.Write("         Resultado de busqueda:");
        Console.Write(encontrado != null ? encontrado.ToString() : "No existe" );

       
        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine($"\n      2)Busqueda del alumno:Leandro Peña");
        Alumno noEncontrado = casoList.BuscarPorNombre("Leandro Peña");
        Console.Write("         Resultado de busqueda:");
        Console.Write(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine($"\n      3)Eliminamos a el alumno de nombre:{alumno2.Nombre}");
        casoList.EliminarAlumno(alumno2);
        Console.WriteLine("             Lista de alumnos actualizada             \n");
        foreach(Alumno alumno in casoList.ObtenerList())
        {
            Console.WriteLine($"Alumno:{alumno}");
        }
        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine($"\n      4)Eliminamos a el alumno de posicion:0 de nombre:{alumno1.Nombre}");
        casoList.EliminarAlumnoPorPosicion(0);
        Console.WriteLine("             Lista de alumnos actualizada             \n");
        foreach (Alumno alumno in casoList.ObtenerList())
        {
            Console.WriteLine($"Alumno:{alumno}");
        }
    }

   
    
    
 
    
    public static void EjemploDictionary()
    {
        Console.WriteLine("******************PRUEBA DE CASO DICTIONARY******************");
        CasoDictionary casoDict = new CasoDictionary();


        // 1. Agregar 3 alumnos (usamos el ID del alumno como Legajo)
        casoDict.AgregarAlumno(321, new Alumno(111, "Rocio Diaz",7.7));
        casoDict.AgregarAlumno(654, new Alumno(222, "Lionel Ruiz", 6.5));
        casoDict.AgregarAlumno(987, new Alumno(333, "Carolina Gimenez", 8.5));

        //Listar por consola los alumnos
        Console.WriteLine("\n--- Lista de Alumnos ---");
        foreach (var kvp in casoDict.ObtenerDiccionario())
        {
            // kvp = KeyValuePair (Par Clave-Valor)
            Console.WriteLine($"Clave: {kvp.Key} | Datos: {kvp.Value}");
        }

        //Buscar un alumno por clave y mostrar por consola

        Console.WriteLine("\n--- Busqueda por Clave: 321 ---");
        Alumno encontrado = casoDict.BuscarPorClave(321);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Busqueda por Clave: 999 ---");
        Alumno noEncontrado = casoDict.BuscarPorClave(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "El alumno no existe");

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminación del alumno de clave:321 ---");
        casoDict.EliminarAlumno(321);

        Console.WriteLine("\n--- Lista de Alumnos Actualizada ---");
        foreach(var kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Alumno clave:{kvp.Key}| Datos: {kvp.Value}");
        }



    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        
        Console.WriteLine("=== PRUEBA DE CASO LINQ ===");
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine($"\n1. Primer libro: {casoLinq.GetPrimero().Titulo}");
        Console.WriteLine($"2. Último libro: {casoLinq.GetUltimo().Titulo}");
        Console.WriteLine($"3. Suma total: {casoLinq.GetTotalPrecios()}");
        Console.WriteLine($"4. Promedio: {casoLinq.GetPromedioPrecios()}");

        Console.WriteLine("\n5. Libros con Id > 15 :");
        foreach (var l in casoLinq.GetListById()) { Console.WriteLine($"- Id {l.Id}: {l.Titulo}"); }

        Console.WriteLine("\n6. Título y Precio formato moneda :");
        foreach (var str in casoLinq.GetLibros()) { Console.WriteLine($"- {str}"); }

        Console.WriteLine($"\n7. Mayor Precio: {casoLinq.GetMayorPrecio().Titulo} ({casoLinq.GetMayorPrecio().Precio})");
        Console.WriteLine($"8. Menor Precio: {casoLinq.GetMenorPrecio().Titulo} ({casoLinq.GetMenorPrecio().Precio})");

        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var l in casoLinq.GetMayorPromedio()) { Console.WriteLine($"- {l.Titulo}: {l.Precio}"); }

        Console.WriteLine("\n10. Ordenados por título descendente :");
        foreach (var l in casoLinq.GetOrdenadosPorTituloDesc()) { Console.WriteLine($"- {l.Titulo}"); }

    }
}
