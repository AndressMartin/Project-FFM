using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    private SpriteRenderer myRenderer;
    [SerializeField] private GameObject highlight;

    public void Init(bool isOffset)
    {
        myRenderer = GetComponent<SpriteRenderer>();
        myRenderer.color = isOffset ? offsetColor : baseColor;
    }

    private void OnMouseEnter()
    {
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        highlight.SetActive(false);
    }
}
