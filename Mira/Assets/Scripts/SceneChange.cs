using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class SceneChange : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject prefab;
    public GameObject avatarobject;
    GameObject instance;
    Vector3 pos;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    
    public void ChangeSceneTrial()
    {
        
        pos = avatarobject.transform.position;
        //print(avatarobject.transform.position);
        // avatarobject.GetComponent<FPSMovement>().pos = pos;
        // avatarobject.GetComponent<FPSMovement>().scenechange1 = true;
        // print(avatarobject.transform.position);
        avatarobject.SetActive(false);
        mainCanvas.SetActive(false);
        instance =  Instantiate(prefab, new Vector3(100f, 100f, 100f), Quaternion.identity);
        
    }

    public void ChangeSceneBack()
    {
        Destroy(instance);
        avatarobject.SetActive(true);
        mainCanvas.SetActive(true);
    }
}
