using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadUserBalance : MonoBehaviour
{
    public Balance userBalance;
    private int[]   data = new int[3];

    void Awake()
    {
        Load();
        userBalance.earnResource(data[0], "Brain");
        userBalance.earnResource(data[1], "Crystal");
        userBalance.earnResource(data[2], "Money");
    }

    void Start()
    {
        SceneManager.activeSceneChanged += SceneChanged;
    }

    void SceneChanged(Scene scen1, Scene scene2)
    {
        Save();
    }

    void OnApplicationQuit()
    {
        Save();
    }

    private void Save()
    {
        // Save information about the User resources anto the array of ints
        // and serialize it into the file called "Balance.gd"
        data[0] = userBalance.getResource("Brain");
        data[1] = userBalance.getResource("Crystal");
        data[2] = userBalance.getResource("Money");
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create (Application.persistentDataPath + "/Balance.gd");
        bf.Serialize(file, data);
        file.Close();
    }

    private void Load()
    {
        // Open file "Balance.gd", deserialize it and store into the array
        if(File.Exists(Application.persistentDataPath + "/Balance.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Balance.gd", FileMode.Open);
            data = (int[])bf.Deserialize(file);
            file.Close();
        }
    }
}
