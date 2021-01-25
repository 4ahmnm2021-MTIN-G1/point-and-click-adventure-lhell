using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerLoad : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene("StartSceneScreen");
    }
}
