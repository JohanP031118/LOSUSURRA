using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void StudentName(TMP_InputField name)
    {
        GameManager.Instance.studentName = name.text;
    }
     public void Choice1(int choice)
    {
        GameManager.Instance.choice1 = choice;
    }

    public void Choice2(int choice) 
    {
        GameManager.Instance.choice2 = choice;
    }

    public void Choice3(int choice)
    {
        GameManager.Instance.choice3 = choice;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
