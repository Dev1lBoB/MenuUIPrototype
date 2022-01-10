using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class PurchaseEvent : MonoBehaviour
{
    public int price;
    public string type;
    public int amount;
    // public AssetReference messageWindowPrefab;
    public GameObject messageWindowPrefab;
    private Balance userBalance;
    private BalanceUIControl userBalanceUIControl;

    void Start()
    {
        GameObject user = GameObject.Find("User");
        userBalance = user.GetComponent<Balance>();
        userBalanceUIControl = user.GetComponent<BalanceUIControl>();
    }

    public void OnClickEvent()
    {
        /*
        ** This method was async and used addressables
        ** but for some reason code only works in Editor
        ** and crashes in Build.
        ** I could not find any way to fix this problem
        ** so I've decided to instantiate object by "default" method.
        ** Here is the code:
        
        // AsyncOperationHandle<GameObject> handle = messageWindowPrefab.LoadAssetAsync<GameObject>();
        // await handle.Task;
        // if (handle.Status == AsyncOperationStatus.Succeeded)
        // {
        //     GameObject msg = handle.Result;
        //     Instantiate(msg);
        //     Addressables.Release(handle);

        */
        GameObject msg = Instantiate(messageWindowPrefab);
        try
        {
            // Try to purchase a product
            userBalance.spendResource(price, "Money"); // Check if user have enough money
            userBalance.earnResource(amount, type); // If so, then give him resources
            msg.transform.Find("Canvas/Text").GetComponent<Text>().text = "Succesfully purchased!"; // Tell aboud success
            userBalanceUIControl.UpdateInfo(); // Then update UI data
        }
        catch
        {
            msg.transform.Find("Canvas/Text").GetComponent<Text>().text = "Not enough money!"; // If user is broke, then tell about failure
        }
        
        // } // End of "If" statement of commented code
    }
}
