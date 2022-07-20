using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    public string itemName;
    public int price;
    [TextArea]
    public string description;
    public Sprite image;
}
