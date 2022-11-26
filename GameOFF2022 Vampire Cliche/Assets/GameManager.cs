using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            Card randomCard = deck[Random.Range(0,deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if(availableCardSlots[i] == true)
                {
                    randomCard.gameObject.SetActive(true);
                    randomCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(randomCard);
                    return;
                }
            }
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            DrawCard();
        }
    }
}
