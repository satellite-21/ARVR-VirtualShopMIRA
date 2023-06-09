using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buymanager : MonoBehaviour
{
    public string id;
    public int price;
    public int qty;
    public GameObject Buycanvas;
    public PopulatGrid obj;
    public void BackButton()
    {
        Buycanvas.SetActive(false);
    }

    public void AddToCartButton()
    {
        Cart.AddItem(id, price, qty);
        Buycanvas.SetActive(false);
        obj.changed = true;
    }
}
