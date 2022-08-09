using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArray : MonoBehaviour
{
    
    public string palabra;
    public char letra;
    public int posicion;

    public int[] ArrayInt;
    // Start is called before the first frame update
    void Start()
    {
        //letra = palabra[posicion];
        //Debug.Log(ArrayInt);
        //SumaArray();
        EscribirPalabraInvertidaLPL(palabra);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SumaArray()
    {
        int total = 0;
        for(int i = 0; i < ArrayInt.Length; i++)
        {
            total += ArrayInt[i];
;       }

        Debug.Log(total);
    }

    void SearChar(string palabra, char searched)
    {
        int counter = 0;
        while (counter < palabra.Length && searched != palabra[counter])
        {
            counter++;
        }

        if (counter == palabra.Length)
        {
            Debug.Log("Letra no encontrada");
        }
        else
        {
            Debug.Log("Letra en posicion " + counter);
        }
    }

    void EscribirPalabraInvertidaLPL(string palabra)
    {
        Debug.Log("inicializado");

        
       
        
            for (int i = palabra.Length - 1; i > 0; i--)
            {
                Debug.Log(palabra[i]);
            }
        
    }
}
