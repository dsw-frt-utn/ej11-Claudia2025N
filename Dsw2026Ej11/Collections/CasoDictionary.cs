namespace Dsw2026Ej11.Collections;
using System.Collections.Generic;
using Dsw2026Ej11.Domain;


public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    private Dictionary<int, Alumno> _diccionario = new Dictionary<int, Alumno>();

    //Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(int legajo,Alumno alumno)
    {
        _diccionario.TryAdd(legajo, alumno);
    }

    //Incluir un método para buscar un alumno utilizando la clave
    public Alumno? BuscarPorClave(int clave)
    {
        if (_diccionario.TryGetValue(clave, out Alumno alumnoEncontrado))
        {
            return alumnoEncontrado;
        }
        return null;
    }
    //Incluir un método para retornar el diccionario
   
    public Dictionary<int,Alumno> ObtenerDiccionario()
    {
        return _diccionario;
    }

    //Incluir un método para eliminar un alumno utilizando la clave

    public void EliminarAlumno(int clave)
    {
        _diccionario.Remove(clave);
    }



}
