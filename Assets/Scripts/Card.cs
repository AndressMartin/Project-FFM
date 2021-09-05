using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    [Header("Type")]
    public CardEnums.Orientation orientation;
    public CardEnums.Origin origin;
    public CardEnums.Type type;
    public CardEnums.Faction faction;
    public CardEnums.Rarity rarity;
    public Sprite sprite;

    [Header("Fields")]
    public string cardName;
    public string description;
    public int actionCost;
    public int manaCost;
    public int extraCost;
}
