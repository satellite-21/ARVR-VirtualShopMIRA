using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AnimatorControllingScript : MonoBehaviour
{
    public GameObject avatar;
    private PhotonView view;
    public bool isAvatarLoaded = false;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAvatarLoaded && view.IsMine)
        {
            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                avatar.GetComponent<Animator>().SetBool("isLStrafing",true);

                
            }
            else
            {
                avatar.GetComponent<Animator>().SetBool("isLStrafing", false);

            }

            if (Input.GetKeyDown(KeyCode.Space) )
            {
                avatar.GetComponent<Animator>().SetTrigger("Jump");


            }
           
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                avatar.GetComponent<Animator>().SetBool("isRStrafing", true);
            }
            else
            {
                avatar.GetComponent<Animator>().SetBool("isRStrafing", false);
            }
            if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
            {
                avatar.GetComponent<Animator>().SetBool("isWalking", true);
                print("W pressed");

            }
            else
            {
                avatar.GetComponent<Animator>().SetBool("isWalking", false);
            }
            if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
            {
                print("DownArrow");
                avatar.GetComponent<Animator>().SetBool("isBackwards", true);
            }
            else
            {
                avatar.GetComponent<Animator>().SetBool("isBackwards", false);
            }

            if (Input.GetKey("t"))
            {
                avatar.GetComponent<Animator>().SetBool("isTalking", true);
                print("t Pressed");
            }
            else
            {
                avatar.GetComponent<Animator>().SetBool("isTalking", false);
            }
        }
    }
}
