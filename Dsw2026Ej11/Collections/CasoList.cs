using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

using System.Linq;
using System.Collections.Generic;




public class CasoList
{
    //Crear un campo que represente una lista de alumnos (List<>)
    private List<Alumno> _alumnos = new List<Alumno>();

    //Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    //Incluir un método para retornar la lista
    public List<Alumno> ObtenerList()
    {
        return _alumnos;
    }

    //Incluir un método para buscar un alumno por nombre
    public Alumno? BuscarPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }
    //Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }


    //Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarAlumnoPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _alumnos.Count)
        {
            _alumnos.RemoveAt(posicion);
        }
    }


}
