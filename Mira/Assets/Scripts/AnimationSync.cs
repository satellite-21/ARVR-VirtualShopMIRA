using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;



public class AnimationSync : MonoBehaviourPunCallbacks, IPunObservable
{
    
    // Start is called before the first frame update
    PhotonView view;
    Animator anim;
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (anim != null) {
            if (view.IsMine)
            {
                if (stream.IsWriting)
                {
                    if (anim != null)
                    {

                        bool isWalking = anim.GetBool("isWalking");
                        bool isBackwards = anim.GetBool("isBackwards");
                        bool isLStrafing = anim.GetBool("isLStrafing");
                        bool isRStrafing = anim.GetBool("isRStrafing");
                        bool istalking = anim.GetBool("isTalking");

                        stream.SendNext(isWalking);
                        stream.SendNext(isBackwards);
                        stream.SendNext(isLStrafing);
                        stream.SendNext(isRStrafing);
                        stream.SendNext(istalking);

                    }

                }
            }
            else
            {
                if (stream.IsReading)
                {
                    bool isWalking = (bool)stream.ReceiveNext();
                    bool isBackwards = (bool)stream.ReceiveNext();
                    bool isLStrafing = (bool)stream.ReceiveNext();
                    bool isRStrafing = (bool)stream.ReceiveNext();
                    bool istalking = (bool)stream.ReceiveNext();
                    anim.SetBool("isWalking", isWalking);
                    anim.SetBool("isBackwards", isBackwards);
                    anim.SetBool("isLStrafing", isLStrafing);
                    anim.SetBool("isRStrafing", isRStrafing);
                    anim.SetBool("isTalking", istalking);

                }
            }
        }
        
    }
        void Start()
    {
        view = gameObject.GetComponent<PhotonView>();
        
    }
    void Update()
    {
        anim = GetComponentInChildren<Animator>();
    }

   
}
