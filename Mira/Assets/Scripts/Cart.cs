using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct iteminCart
{
    public string itemid;
    public int qty;
    public int price;
};
public static class Cart
{

    public static Dictionary<string,iteminCart> cart = new Dictionary<string, iteminCart>();
   public static void AddItem(string id,int price, int qty=1)
    {
        if (!cart.ContainsKey(id)) {
            iteminCart tmp;
            tmp.itemid = id;
            tmp.price = price;
            tmp.qty = qty;
            cart.Add(id, tmp);
        }
        else
        {
            
            iteminCart tmp = cart[id];
            tmp.qty += qty;
            cart.Add(id, tmp);
        }
        

    }

    public static void removeitem(string id,int qty)
    {
        if (qty >= cart[id].qty)
        {
            cart.Remove(id);
        }
        else
        {

            iteminCart tmp = cart[id];
            tmp.qty -= qty;
            cart.Remove(id);
            cart.Add(id, tmp);
        }

    }


}
