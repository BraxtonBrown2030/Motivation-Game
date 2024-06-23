using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingConsolePrint : MonoBehaviour
{
    
    public void PrintToConsole()
    {
        Debug.Log("working");
    }
    public void PrintToConsole(string message)
    {
        Debug.Log(message);
    }
    
}
