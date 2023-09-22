using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [HideInInspector]
    public string studentName;
    [HideInInspector]
    public int choice1;
    [HideInInspector]
    public int choice2;
    [HideInInspector]
    public int choice3;


    public TMP_InputField nameInputField;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(choice1 != 0)
        {
            Debug.Log(choice1);
        }
        if (choice2 != 0)
        {
            Debug.Log(choice2);
        }
        if (choice3 != 0)
        {
            Debug.Log(choice3);
        }
    }
}
