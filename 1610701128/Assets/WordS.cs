using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordS : MonoBehaviour
{
    public string search;
    public GameObject inputField;
    public GameObject textDisplay;

    public void Search()
    {
        string[] word = { "GGEZ", "NiceGame", "Booooom", "Go", "Move" };
        string inp = inputField.GetComponent<InputField>().text;
        bool checker = false;
        foreach (string word1 in word)
        {
            if (word1.Equals(inp))
            {
                checker = true;
                break;
            }
        }
        if (checker)
        {
            textDisplay.GetComponent<Text>().text = "Found";
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "Not Found";
        }
    }


}
