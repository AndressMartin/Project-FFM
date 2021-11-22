using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : SingletonInstance<PlayerInventory>
{
    public List<Card_> allCardsScriptable;
    public List<Card> obtainedCards;
    public List<Card> allCards;


    public void CreateCardFromScriptableObj()
    {
        allCards = new List<Card>();
        foreach (var scriptableCard in allCardsScriptable)
        {

        }
    }

    private void Start()
    {
        doSomething();
        int resultado = multiply(2, 4);
        print(resultado);
    }

    public void doSomething()
    {
        //I did something and must return nothing.
    }

    public int multiply(int a, int b)
    {
        //I return the multiplication of my parameters.
        return a * b;
    }

}
