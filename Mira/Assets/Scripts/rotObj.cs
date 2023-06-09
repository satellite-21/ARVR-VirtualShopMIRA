using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    float rotSpeed = 20;
    private void Update()
    {
        //print(Input.touchCount);
        if (Input.touchCount == 1)
        {
            Touch screenTouch = Input.GetTouch(0);
            if(screenTouch.phase == TouchPhase.Moved)
            {
                transform.Rotate(screenTouch.deltaPosition.y, screenTouch.deltaPosition.x, 0f);
            }
        }
        float rotSpeed = 20;
        if (Input.GetMouseButton(0))
        {
            //print("Mouse down");
            transform.Rotate(Input.GetAxis("Mouse Y") * rotSpeed, Input.GetAxis("Mouse X") * rotSpeed, 0f);
        }
    }

}
