using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    private List<Message>   messageList;
    private int             maxNmbrOfMessages;
    public GameObject       chatPanel;
    public GameObject       textObject;
    public InputField       chatBox;

    void Start()
    {
        messageList = new List<Message>();
        maxNmbrOfMessages = 20; // The maximum number of messages. After overflowing the first message will be deleted
    }

    void Update()
    {
        if (chatBox.text != "")
        {
            // Send message to the chat only if chatBox isn't empty and the "Enter" is pressed
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SendMessageToChat(chatBox.text);
                chatBox.text = ""; // Empty chatBox after sending a message
            }
        }
    }

    public void SendMessageToChat(string text)
    {
        if (messageList.Count >= maxNmbrOfMessages)
        {
            // Get rid of the last message if their number reaches maximum
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }

        GameObject newText = Instantiate(textObject, chatPanel.transform);

        Message newMessage = new Message(text, newText.GetComponent<Text>());
        messageList.Add(newMessage);
    }
}
