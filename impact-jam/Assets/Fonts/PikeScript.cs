using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PikeScript : MonoBehaviour
{
    private Scene m_Scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_Scene = SceneManager.GetActiveScene();
    }

    void reloadScene(string sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        reloadScene(m_Scene.name);
    }
}
