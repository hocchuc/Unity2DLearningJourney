using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int value = 0;
    // Use this for initialization
    void Start()
    {
   
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Please pick a number");
        Debug.Log("Max is: " + max);
        Debug.Log("Min is: " + min);
        Debug.Log("please use Up, Down and Enter to pick.");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            value++;
            ShowValue();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            value--;
            ShowValue();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct: " + value);
        }
    }

    void ShowValue()
    {
        Debug.Log("value:" + value);
    }

}
