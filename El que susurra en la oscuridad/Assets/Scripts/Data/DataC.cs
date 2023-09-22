using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataC : System.Object
{
    // Start is called before the first frame update

    [SerializeField]
    private int id;
    [SerializeField]
    public string student_name;
    [SerializeField]
    public int input1;
    [SerializeField]
    public int input2;
    [SerializeField]
    public int input3;

   public DataC() 
    {
    }

    public DataC(int id, string student_name, int input1, int input2, int input3)
    {
        this.id = id;
        this.student_name = student_name;
        this.input1 = input1;
        this.input2 = input2;
        this.input3 = input3;
    }

    public int getId()
    {
        return this.id;
    }

    public void setId(int id)
    {
        this.id = id;
    }
}
