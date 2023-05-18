using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChangeScene : MonoBehaviour
{
    public string scene;
    public void OnClick()
    {
        Debug.Log("Change Scene");
        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }
}
