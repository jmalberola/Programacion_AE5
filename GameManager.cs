using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<Card> baraja = new List<Card>();

    Player p = new Player();
    int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitDeck()
    {
        for(int i=0; i < 52; i++)
        {
            Card c = new Card();
            if (i < 13)
            {
                c.palo = "corazones";
                c.numero = i;
                if(i==0 || i >= 10)
                {
                    c.puntuacion = 10;
                }
                else
                    c.puntuacion = i;
            }
            if (i >= 13 && i < 26)
            {
                if (i == 13 || i >= 23)
                {
                    c.puntuacion = 10;
                }
                else
                    c.puntuacion = i;

                c.palo = "picas";
            }
            if (i >= 26 && i < 39)
            {
                if (i == 26 || i >= 36)
                {
                    c.puntuacion = 10;
                }
                else
                    c.puntuacion = i;

                c.palo = "treboles";
            }
            if (i >= 39)
            {
                if (i == 39 || i >= 50)
                {
                    c.puntuacion = 10;
                }
                else
                    c.puntuacion = i;

                c.palo = "rombos";
            }

            baraja.Add(c);
        }                        
                
    }


    void NextCard()
    {
        //Sacamos una carta aleatoria
        int repartir=Random.Range(0, baraja.Count);
        p.DealCard(baraja[repartir]);

        //Llamamos a printInfo y a GetPoints
        baraja[repartir].PrintInfo();
        p.GetPoints();

        //Opción 1: borro la carta
        baraja.Remove(baraja[repartir]);

        //Opción 2: borro la carta que esté en la posición
        //baraja.RemoveAt(repartir);

    }

}
