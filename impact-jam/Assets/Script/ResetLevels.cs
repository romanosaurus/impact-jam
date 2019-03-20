using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevels : MonoBehaviour
{
    static Scene m_scene;

    void Update()
    {
        m_scene = SceneManager.GetActiveScene();
    }

    public void ResetActualLevel()
    {
        SceneManager.LoadScene(m_scene.name);
    }
}
