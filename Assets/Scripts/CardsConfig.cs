using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card Configuration", menuName = "Card/Config")]
public class CardsConfig : ScriptableObject
{
    public List<Color> factionColors = new List<Color>();
    public List<Color> orientationColors = new List<Color>();
    public List<Color> originColors = new List<Color>();
    public List<Color> typeColors = new List<Color>();
    public List<Color> rarityColors = new List<Color>();
}
