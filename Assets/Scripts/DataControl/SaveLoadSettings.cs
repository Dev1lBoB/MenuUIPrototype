using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadSettings : MonoBehaviour
{
    public Slider musicSlider;
    public Slider soundsSlider;
    private float[] data = new float[2];

    void Awake()
    {
        Load();
        musicSlider.value = data[0];
        soundsSlider.value = data[1];
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
        // Save information about the settings anto the array of floats
        // and serialize it into the file called "Settings.gd"
        data[0] = musicSlider.value;
        data[1] = soundsSlider.value;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create (Application.persistentDataPath + "/Settings.gd");
        bf.Serialize(file, data);
        file.Close();
    }

    private void Load()
    {
        // Open file "Settings.gd", deserialize it and store into the array
        if(File.Exists(Application.persistentDataPath + "/Settings.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Settings.gd", FileMode.Open);
            data = (float[])bf.Deserialize(file);
            file.Close();
        }
    }
}
