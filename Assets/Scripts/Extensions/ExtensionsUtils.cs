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
}
