using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionsUtils 
{
    public static void Scale(this Transform scaleTransform, float scaleSize = 1.2f)
    {
        scaleTransform.localScale = Vector3.one * scaleSize; 
    }
    public static void ScaleVector(this Vector3 scaleVector, float scaleSize = 1.2f)
    {
        //scaleVector.localScale = Vector3.one * scaleSize; 
    }
    public static void ScaleGameObject(this GameObject scaleGameObject, float scaleSize = 1.2f)
    {
        scaleGameObject.transform.localScale = Vector3.one * scaleSize; 
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandom<T>(this T[] array)
    {
        if (array.Length == 0)
        {
            return default(T);
        }

        return array[Random.Range(0, array.Length)];
    }

    public static T GetRandomButNotTheSame<T>(this List<T> list, T unique)
    {
        if (list.Count == 1)
        {
            return unique;
        }
        var randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }
}
