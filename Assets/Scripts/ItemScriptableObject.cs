using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item", order = 0)]
public class ItemScriptableObject : ScriptableObject
{
    public string itemName;
    public int price;
    [TextArea]
    public string description;
    public Sprite image;
}
