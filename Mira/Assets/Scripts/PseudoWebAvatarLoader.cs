using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PseudoWebAvatarLoader : MonoBehaviour
{
    public void Awake()
    {
        PartnerSO partner = Resources.Load<PartnerSO>("Partner");
        WebInterface.SetupRpmFrame(partner.Subdomain);
    }
    public void OnWebViewAvatarGenerated(string avatarUrl)
    {
        Debug.Log("Avatar @ " + avatarUrl);
        var Players = GameObject.FindGameObjectsWithTag("Prefab");
        foreach (var item in Players)
        {
            Debug.Log("Avatar1 @ "+avatarUrl);
            item.GetComponent<WebAvatarLoader>().OnWebViewAvatarGenerated(avatarUrl);
        }
    
    }
    }
