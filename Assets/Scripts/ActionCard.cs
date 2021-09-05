using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card/Action")]
public class ActionCard : Card
{
    public int range;
    public int duration;
    public int effect;
}
