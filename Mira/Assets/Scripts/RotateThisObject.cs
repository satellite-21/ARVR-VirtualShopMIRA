using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateThisObject : MonoBehaviour
{
    public Vector3 deltaRotation;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localRotation *= Quaternion.Euler(deltaRotation[0], deltaRotation[1], deltaRotation[2]);
        
    }
}
