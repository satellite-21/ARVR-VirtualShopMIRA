using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScrip : MonoBehaviour
{
    GameObject scenemanager;
    // Start is called before the first frame update
    void Start()
    {
        scenemanager = GameObject.Find("SceneManager");
    }

    // Update is called once per frame
    public void Back()
    {
        scenemanager.GetComponent<SceneChange>().ChangeSceneBack();
    }
}
