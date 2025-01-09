using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int deckSize;
    public PlayerType playerType;
    public enum PlayerType
    {
        Archer, //has more long range attacks
        Mage, //has more power cards
        Warrior, //has more melee attacks
    }
}
