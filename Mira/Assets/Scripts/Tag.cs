using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Tag : MonoBehaviour
{
    public string id;
    public int price;
    public float detectionRange;
    bool closeEnough;
   public static Transform player ;
    [SerializeField]
    public  GameObject message;
    [SerializeField]
    public  GameObject Buycanvas;
    [SerializeField]
    public  TextMeshProUGUI pid;
    [SerializeField]
    public  TextMeshProUGUI pricetxt;
    [SerializeField]
    public  TMP_InputField qtyinp;
    public static bool enable=false;
    public static string enableid;
    public buymanager manager;


    void Update()
    {
        if(player != null) {
            closeEnough = false;
            if (Vector3.Distance(player.position, transform.position) <= detectionRange)
            {
                closeEnough = true;
            }
            if (closeEnough && Input.GetKeyUp(KeyCode.B))
            {
                //Open the Buy Canvas
                pid.text = id;
                pricetxt.text = "$ " + price.ToString();
                Buycanvas.SetActive(true);

            }
            if (closeEnough)
            {
                manager.id = id;
                manager.price = price;
                try { manager.qty = int.Parse(qtyinp.text); }
                catch
                {
                    manager.qty = 1;
                    print("This Executes");
                }
            }
        }
        
       
    }

    void OnGUI()
    {

 if(closeEnough){
            //Do Open message stuff
            enable =  true;
            enableid = id;
            
 }
        else
        {
            if (enableid == id)
            {
                enable = false;
            }
        }
        message.SetActive(enable);
    }

  
    

}
