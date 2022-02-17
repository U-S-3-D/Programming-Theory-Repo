using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainScreen : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("MainScreen", LoadSceneMode.Single);
    }
}
