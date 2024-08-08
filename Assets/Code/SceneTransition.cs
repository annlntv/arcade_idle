using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneTransition : MonoBehaviour
{
    [SerializeField] GameObject loadingScreen;
    [SerializeField] GameObject mainCanvas;
    [SerializeField] Slider bar;
    int index;
    private void Start()
    {
        loadingScreen.SetActive(false);
    }

    public void SceneLoader(int indexs)
    {
        index = indexs;
        loadingScreen.SetActive(true);
        mainCanvas.SetActive(false);
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);
        while (!operation.isDone)
        {
            bar.value = operation.progress;
            print(bar.value);
            yield return null;
        }
    }
}