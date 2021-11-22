using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsManager : SingletonInstance<CardsManager>
{
    public CardsConfig cardsConfig;
    public PlayerInventory playerInventory;
    public void Init() 
    {
        CreateCards();
    }

    private void CreateCards()
    {
        foreach (var card in playerInventory.obtainedCards)
        {
            Instantiate(card);
            card.Init();
        }
    }
}
