using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica2 : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {
        string[] nombres = {"Alvez Abimael", "Cristian Astorga",
                            "Becerra Erick", "Chagala Edgar",
                            "Diaz Luis", "Esqueda Luis",
                            "Hernandez Isaac", "Landa Edgar",
                            "Lazcano Luis", "Lopez Nereo",
                            "Luevano Araceli", "Martinez Sergio",
                            "Martinez Jorge", "Morales Ivan",
                            "Quintero Feliz", "Raygoza Brandon",
                            "Roriguez Raul", "Rosas Miguel",
                            "Santos Daniel", "Tapia Jose"};

        Debug.Log(SearchName(nombres, "Tapia Jose"));

        Debug.Log(SearchName(nombres, "No nombre"));
    }

    /* Se utiliza la funcion BinarySearch de la clase Array.
    Esta funcion comienza en la mitad del arreglo para ver si encuentra
    el objeto buscado, de no hacerlo identifica si este objeto se encuentra
    en la mitad superior o inferior del arreglo para irse a la mitad de esa
    seccion y seguir realizando su busqueda.
    Esta funcion tiene una complejidad de O(log n) en su peor de los casos, 
    en el mejor de los casos tiene una complejidad de O(1).
    */
    private bool SearchName(string[] nombres, string nombre)
    {
        bool aux = false;

        if(Array.BinarySearch(nombres,nombre) >= 0)
            aux = true;

        return aux;
    }

}
