using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Potion", menuName = "Items/Potion", order = 0)]
public class PotionScriptableObject : ItemScriptableObject
{
    public override void Use()
    {
        //Do something
    }
}