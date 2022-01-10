using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableDisableShop : MonoBehaviour
{
    private ShopScroller shopScroll;

    // Start is called before the first frame update
    void Start()
    {
        GameObject shop = GameObject.Find("Shop");
        shopScroll = shop.GetComponent<ShopScroller>();
    }

    public void EnableShop()
    {
        shopScroll.scrollRect.enabled = true;
    }

    public void DisableShop()
    {
        shopScroll.scrollRect.enabled = false;
    }
}
