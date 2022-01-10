using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;

    public Message(string txt, Text to)
    {
        text = txt;
        textObject = to;
        textObject.text = text;
    }
}
