using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public GameObject chat;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void DisableEnableChat()
    {
        // Change the active status of the object to the opposite using the same button
        chat.gameObject.SetActive(!chat.gameObject.activeSelf); 
    }
}
