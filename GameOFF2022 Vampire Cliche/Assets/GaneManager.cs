using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaneManager : MonoBehaviour
{
    public List<CardFunctions> deck = new List<CardFunctions>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    public void DrawCards()
    {
        if(deck.Count >= 1)
        {
            CardFunctions randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if( availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(randCard);
                    return;
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey("q"))
        {
            DrawCards();    
        }
    }
}
