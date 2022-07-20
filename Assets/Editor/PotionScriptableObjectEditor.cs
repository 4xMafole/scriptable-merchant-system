using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

[CustomEditor(typeof(PotionScriptableObject))]
public class PotionScriptableObjectEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var potionScriptableObject = (PotionScriptableObject)target;
        if (potionScriptableObject.image == null) return;

        GUILayout.Box(potionScriptableObject.image.texture);

        if (GUILayout.Button("Test Use"))
        {
            potionScriptableObject.Use();
        }
    }
}