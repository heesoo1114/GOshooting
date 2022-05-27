using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void Scene_oader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
