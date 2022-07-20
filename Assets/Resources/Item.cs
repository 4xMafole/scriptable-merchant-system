using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    public string itemName;
    public int price;
    [TextArea]
    public string description;
    public Sprite image;

    public abstract void Use();
}
