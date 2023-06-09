using UnityEngine;

public class DemoCanvas : MonoBehaviour
{

    private void Awake()
    {
        //OnCreateAvatar();
    }
    public static void OnCreateAvatar()
    {
        WebInterface.SetIFrameVisibility(true);
    }

    public void EnterCartView()
    {
        var cartview = GetChildWithName(gameObject, "CartView");
        cartview.SetActive(true);
    }

    public void ExitCartView()
    {
        var cartview = GetChildWithName(gameObject, "CartView");
        cartview.SetActive(false);
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
