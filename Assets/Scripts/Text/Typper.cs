using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using NaughtyAttributes;

public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters = 0.1f;
    public string phrase;

    private void Awake()
    {
        textMesh.text = "";
    }

    [Button]
    public void StartType()
    {
        StartCoroutine(Type(phrase));
    }
    private IEnumerator Type(string typeString)
    {
        textMesh.text = "";
        foreach (var letter in typeString.ToCharArray())
        {
            textMesh.text += letter;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}
