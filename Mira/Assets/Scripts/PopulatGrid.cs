using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopulatGrid : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public bool changed = false;
    
    List<GameObject> populated = new List<GameObject>();
    void Start()
    {
        changed = true;
    }
    private void Update()
    {
        Populate(); // Will constantly update UI w
    }
    public void Populate() // Populate the scoll View 
    {
        if (changed)
        {
            foreach (var child in populated)
            {
                Destroy(child);
            }
            changed = false;



            GameObject newcard;
            // Copying data into Cards  and formatting it for UI

            foreach (var i in Cart.cart.Keys)
            {
                newcard = (GameObject)Instantiate(prefab, transform);
                newcard.GetComponent<RemoveCart>().qty = Cart.cart[i].qty;
                var pid = GetChildWithName(newcard, "PID");
                var qty = GetChildWithName(newcard, "QTY");
                var price = GetChildWithName(newcard, "Price");
                pid.GetComponent<TextMeshProUGUI>().text = Cart.cart[i].itemid;
                qty.GetComponent<TextMeshProUGUI>().text = Cart.cart[i].qty.ToString();
                price.GetComponent<TextMeshProUGUI>().text = "$ " + Cart.cart[i].price.ToString();
                populated.Add(newcard);

            }
        }
       
            
        
    }
    GameObject GetChildWithName(GameObject obj, string name)
    {
        Transform trans = obj.transform;
        Transform childTrans = trans.Find(name);
        if (childTrans != null)
        {
            return childTrans.gameObject;
        }
        else
        {
            return null;
        }
    }

}
