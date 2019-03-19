using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{

    public void LoadScene(string sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}