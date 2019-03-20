using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapScript : MonoBehaviour
{
    [SerializeField]
    private GameObject firstState;
    [SerializeField]
    private GameObject secondState;
    [SerializeField]
    private GameObject thirdState;
    private float sinceTrapped;
    private bool isTrapped;
    private bool alreadyTrapped;
    private Scene m_Scene;
    private bool isClosed;
    // Start is called before the first frame update
    void Start()
    {
        isTrapped = false;
        alreadyTrapped = false;
        sinceTrapped = 0;
        isClosed = false;
    }

    // Update is called once per frame
    void Update()
    {
        m_Scene = SceneManager.GetActiveScene();
        if (sinceTrapped == 0 && isTrapped && !alreadyTrapped)
        {
            firstState.SetActive(false);
            secondState.SetActive(true);
            alreadyTrapped = true;
        }
        if (alreadyTrapped || sinceTrapped > 0) {
            sinceTrapped += Time.deltaTime;
        }
        if (sinceTrapped >= 2)
        {
            sinceTrapped = 0;
            thirdState.SetActive(false);
            firstState.SetActive(true);
            isClosed = false;
        }
        if (sinceTrapped >= 0.42 && isClosed == false)
        {
            isClosed = true;
            secondState.SetActive(false);
            thirdState.SetActive(true);
            if (isTrapped)
                reloadScene(m_Scene.name);
            isTrapped = false;
            alreadyTrapped = false;
        }
    }

    void reloadScene(string sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isTrapped = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isTrapped = true;
        
        Debug.Log("OnCollisionEnter2D");
    }
}
