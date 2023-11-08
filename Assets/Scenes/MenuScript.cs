using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnGUI()
    {
        GUI.Box(new Rect(10,10,110,90),"Loader Level");
        if (GUI.Button(new Rect(25,35,80,20),"Level 1"))
        {
            SceneManager.LoadScene(1);
        }
        if (GUI.Button(new Rect(25,65,80,20),"Level 2"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
