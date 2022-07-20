using System.Collections.Generic;
using UnityEngine;

public abstract class ItemScriptableObject : ScriptableObject
{
    public string itemName;
    public int price;
    [TextArea]
    public string description;
    public Sprite image;

    public abstract void Use();
}
