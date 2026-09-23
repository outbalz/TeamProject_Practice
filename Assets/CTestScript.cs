using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTestScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("H World!");
        Debug.Log("He World!");
        Debug.Log(", World!");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Hello, World!");
        }        
    }
}
