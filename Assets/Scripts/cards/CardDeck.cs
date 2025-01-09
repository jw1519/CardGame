using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeck : MonoBehaviour
{
    public int cardAmount;
    public List<Card> cards;

    public void StartPlayersTurn()
    {
        cardAmount = cardAmount - 7;
    }
    public void AddCardToHand()
    {
        cardAmount = cardAmount - 1;
    }
    public void AddCardToDeck(Card card)
    {
        cards.Add(card);
        cardAmount++;
    }
}
