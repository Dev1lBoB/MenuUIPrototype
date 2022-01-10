using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
 
public class DeactivateButtons : MonoBehaviour
{ 
    GameObject[] objs;

    void Start()
    {
        // Find all buttons thats inside the "Shop" by the tag
        objs = GameObject.FindGameObjectsWithTag("ShopButton");
    }

    public void DeactivateAllButtons()
    {
        foreach (GameObject button in objs)
        {
            button.GetComponent<Button>().interactable = false;
        }
    }

    public void AcivateAllButtons()
    {
        foreach (GameObject button in objs)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
}