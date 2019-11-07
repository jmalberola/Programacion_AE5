using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string palo;
    public int numero;
    public int puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintInfo()
    {
        Debug.Log("Los datos son " + palo + " " + numero + " " + puntuacion);
    }
}
