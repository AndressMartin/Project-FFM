using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardMiniDisplay : MonoBehaviour
{
    public ActionCard_ card;
    public Image cardImage;
    public TextMeshProUGUI actionCost;
    private void Start()
    {
        cardImage.sprite = card.sprite;
        actionCost.text = card.actionCost.ToString();
    }
}
