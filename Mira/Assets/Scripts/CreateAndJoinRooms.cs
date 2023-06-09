using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.SceneManagement;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
       
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
       
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("ShoppingSpace");
        DemoCanvas.OnCreateAvatar();
    }
}
