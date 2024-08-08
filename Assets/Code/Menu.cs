using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] int sceneName;
    SceneTransition transition;
    public void Start()
    {
        transition = FindObjectOfType<SceneTransition>();
    }
    public void OnClickStart()
    {
        //SceneManager.LoadScene(sceneName);
        transition.SceneLoader(sceneName);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}