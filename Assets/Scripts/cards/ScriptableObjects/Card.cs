using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(fileName = "Cards", menuName = "card")]
public class Card : ScriptableObject
{
    public Sprite cardSprite;
    public int power;
    public PowerType powerType;
    public string cardName;
    public string cardDescription;
    public CardType cardType;
    public int Block;
    public int damage;

    public enum CardType
    {
        Attack,
        Defence,
        Power
    }
    public enum PowerType
    {
        Earth,
        Light,
        Dark,
    }
}
