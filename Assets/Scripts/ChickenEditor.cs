using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(chicken))]
public class ChickenEditor : Editor
{
    public override void OnInspectorGUI()
    {

        DrawDefaultInspector();

        chicken chicken = (chicken)target;
        if (GUILayout.Button("Redraw Co op"))
        {
            chicken.resizeCoop();
        }
    }
}
