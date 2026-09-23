using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTestScript : MonoBehaviour
{
    private void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Hello, World!");
        }        
    }
}
