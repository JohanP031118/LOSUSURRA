using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class GameDataAdmin : MonoBehaviour
{
    public DataC myData;
   
    // Start is called before the first frame update
    void Start()
    {
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";

        if (File.Exists(filePat))
        {
            string s = File.ReadAllText(filePat);
            myData = JsonUtility.FromJson<DataC>(s);
        }
        else
        {
            myData = new DataC(1,"",0,0,0);
            string s = JsonUtility.ToJson(myData,true);
            File.WriteAllText(filePat, s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveConfig()
    {
        string filePat = Application.streamingAssetsPath + "/" + "data1.json";

        if (File.Exists(filePat))
        {
            myData.student_name = GameManager.Instance.studentName;
            myData.input1 = GameManager.Instance.choice1;
            myData.input2 = GameManager.Instance.choice2;
            myData.input3 = GameManager.Instance.choice3;

            string s  = JsonUtility.ToJson(myData,true);

            File.WriteAllText(filePat, s);
        } 
        else
        {
            myData = new DataC(1, "Estudiante", 0, 0, 0);
            string s = JsonUtility.ToJson(myData,true);

            File.WriteAllText(filePat, s);
        }
    }
}
