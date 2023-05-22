using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Car))]
public class EditorCar : Editor
{
    public override void OnInspectorGUI()
    {
        Car myTarget = (Car)target;
        myTarget.speed = EditorGUILayout.IntField("My Speed", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("My Gear", myTarget.gear);
        myTarget.carPrefab = (GameObject)EditorGUILayout.ObjectField
            (myTarget.carPrefab, typeof(GameObject), true);
        EditorGUILayout.LabelField("Total Speed", myTarget.TotalSpeed.ToString());
        EditorGUILayout.HelpBox("Calculate Total Speed", MessageType.Info);
        
        if (myTarget.TotalSpeed > 200)
        {
            EditorGUILayout.HelpBox("Over Limit Speed", MessageType.Error); 
        }
        GUI.color = Color.cyan;
        if (GUILayout.Button("Create Car"))
        {
            myTarget.CreateCar();
        }
        GUI.color = Color.blue;
        if (GUILayout.Button("Test Color"))
        {
            Debug.Log("Testing button color");
        }
    }
}
