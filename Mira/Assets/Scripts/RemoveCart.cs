using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemoveCart : MonoBehaviour
{
    public TextMeshProUGUI id;
    public int qty;
    
    public void removefromcart()
    {
        Cart.removeitem(id.text, qty);
        Destroy(gameObject);
    }

    public void AddMeshTrial()
    {
        string idx = id.text;
       var obj = GameObject.Find("ObjectHolder");
        for(int i = 0; i < obj.transform.childCount; i++)
        {
            Destroy(obj.transform.GetChild(i).gameObject);
        }
        if (idx == "T0")
        {
            Instantiate(Resources.Load("T0"), obj.transform);
        }
        else if (idx == "T1")
        {
            Instantiate(Resources.Load("T1"), obj.transform);
        }
        else if (idx == "T2")
        {
            Instantiate(Resources.Load("T2"), obj.transform);
        }
        else if (idx == "T3")
        {
            Instantiate(Resources.Load("T3"), obj.transform);
        }
        else if (idx == "YBoot")
        {
            Instantiate(Resources.Load("YBoot"), obj.transform);
        }
        else if (idx == "BBoot")
        {
            Instantiate(Resources.Load("BBoot"), obj.transform);
        }
        else if (idx == "BlackBoot")
        {
            Instantiate(Resources.Load("BlackBoot"), obj.transform);
        }
        else if (idx == "RBoot")
        {
            Instantiate(Resources.Load("RBoot"), obj.transform);
        }


    }
}
