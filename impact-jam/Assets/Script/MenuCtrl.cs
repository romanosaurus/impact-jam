using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{

    public void LoadScene(string sceneIndex)
    {
//        for (int i = 0; i != 1000000000; i++);
        SceneManager.LoadScene(sceneIndex);
    }
}