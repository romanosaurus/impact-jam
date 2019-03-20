using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Properties : MonoBehaviour
{
    public float speed;
    public float speedSprint;
    public float jumpForce;
    private Scene m_Scene;

    void Update()
    {
        m_Scene = SceneManager.GetActiveScene();

        if (transform.position.y < -10)
            reloadScene(m_Scene.name);
    }

    void reloadScene(string sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
