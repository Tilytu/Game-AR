using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammingBasics : MonoBehaviour
{
    //variables
    int a = 4;
    float b = 4f;
    float c = -2.14f;
    //public variable:a variable that is accessible in the unity editor.
    //(you can edit its value in a little box that appears on the script component)
    public int d = 5;
    // Use this for initialization
    void Start()
    {
        actionFun(3);//calling this function ,this one print out 7
        outputFun(3);//this one doesnot print anything,but the value of outputFun(3)is 7.
        print(outputFun(3));//this actually prints 7
        happy(d);
    }

    // Update is called once per frame
    void Update()
    {
        if (d < 4)
        {
            print(a + d);
        }
        else if (d >= 4 && d < 10)
        {
            print("hello");
        }
        else
        {
            print("d is 10 or greater");
        }
    }//this is where we write functions:between the end of the update function
     //and the end of the script.
     //input->fuction->ACTION AND/OR OUTPUT
     //a fuction always carries out an action, but may not have inpt or output

    //ex:function that takes in an INPUT and produces an ACTION
    void actionFun(int x)
    {
        print(x + 4);
    }

    //ex:funvtion that takes in an INPUT and produces OUTPUT
    int outputFun(int x) {
        return x + 4;
    }

    //write a funcftion that tells you if the current value of d is greaterthan 100 or not.
    void happy(int x)
    {
        if (x> 100)
        {
            print(" greater than 100");
        }
        else
        {
            print(" smaller than 100");
        }
    }
}
