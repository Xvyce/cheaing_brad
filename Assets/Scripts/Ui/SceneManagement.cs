using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        PlayerPrefs.SetFloat("CurrentScore", 0);
        SceneManager.LoadScene(sceneName);
    }
}
