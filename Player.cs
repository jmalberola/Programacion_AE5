using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Card> mano = new List<Card>();
    int puntos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealCard(Card c)
    {
        mano.Add(c);
        SetPoints();
    }

    void SetPoints()
    {
        int suma = 0;

        for(int i=0;i < mano.Count; i++)
        {
            suma = suma + mano[i].puntuacion;
        }

        puntos = suma;
    }

    public int GetPoints()
    {
        return puntos;
    }
}
