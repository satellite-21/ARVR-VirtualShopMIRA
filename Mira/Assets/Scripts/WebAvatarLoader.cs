using ReadyPlayerMe;
using UnityEngine;
using Photon.Pun;

public class WebAvatarLoader : MonoBehaviour
{

    private GameObject avatar;
    private string AvatarURL = "";
    private AvatarLoader avatarLoader;
    public PhotonView view;
    

    private void Start()
    {
        
        avatarLoader = new AvatarLoader();
        view = GetComponent<PhotonView>();
        if (view.IsMine)
        {
            Tag.player = gameObject.transform;
            var scenemanager = GameObject.Find("SceneManager");
            scenemanager.GetComponent<SceneChange>().avatarobject = gameObject;
        }
    }
    [PunRPC]
    public void recieveAvatar(string hash)
    {
        var array_inputstrings = hash.Split(',');
        string actor_s=array_inputstrings[0];
        string avatarurl=array_inputstrings[1];
        if (actor_s.CompareTo(view.OwnerActorNr.ToString()) == 0 && (!view.IsMine))
        {
            Debug.Log("Avatar3 @ " + avatarurl);
            LoadAvatar(avatarurl); 
        }
    }
    public void OnWebViewAvatarGenerated(string avatarUrl)
    {
        Debug.Log("Avatar2 @ " + avatarUrl);
        if (view.IsMine)
        {
            
            string hash = view.OwnerActorNr.ToString() + "," + avatarUrl;

            gameObject.GetComponent<FPSMovement>().enabled = false;
            view.RPC("recieveAvatar",RpcTarget.OthersBuffered,hash);
            LoadAvatar(avatarUrl);
        }

    }
    
    public void LoadAvatar(string avatarUrl)
    {
        AvatarURL = avatarUrl;
        avatarLoader.LoadAvatar(AvatarURL, OnAvatarImported, OnAvatarLoaded);
        if (avatar) Destroy(avatar);
    }

    private void OnAvatarImported(GameObject avatar)
    {
        Debug.Log($"Avatar imported. [{Time.timeSinceLevelLoad:F2}]");
    }

    private void OnAvatarLoaded(GameObject avatar, AvatarMetaData metaData)
    {
        
        this.avatar = avatar;
        var anim= this.avatar.AddComponent<PhotonAnimatorView>();
       
        this.avatar.transform.SetParent(gameObject.transform,true);
        this.avatar.transform.localPosition = new Vector3(0, 0, 0);
        this.avatar.transform.localRotation = Quaternion.identity;
        gameObject.GetComponent<FPSMovement>().enabled = true;
        gameObject.GetComponent<AnimatorControllingScript>().avatar = avatar;
        gameObject.GetComponent<AnimatorControllingScript>().isAvatarLoaded = true;
        Debug.Log($"Avatar loaded. [{Time.timeSinceLevelLoad:F2}]\n\n{metaData}");
    }
}
