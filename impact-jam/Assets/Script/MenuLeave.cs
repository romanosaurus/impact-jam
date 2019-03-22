using UnityEngine;
using System.Collections;

public class MenuLeave : MonoBehaviour
{

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
//        for (int i = 0; i != 1000000000; i++);
        Application.Quit ();
    }
}