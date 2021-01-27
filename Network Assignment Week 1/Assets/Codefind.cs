using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Codefind : MonoBehaviour
{
    public string FindWord;
    public GameObject inputField;
    public GameObject textDisplay;

    public void Names()
    {

        FindWord = inputField.GetComponent<Text>().text;

        if (FindWord == "Doraemon")
        {
            textDisplay.GetComponent<Text>().text = "[" + FindWord + "]" + "is found";
        }
        else if (FindWord == "Nobita")
        {
            textDisplay.GetComponent<Text>().text = "[" + FindWord + "]" + "is found";
        }
        else if (FindWord == "Shizuka")
        {
            textDisplay.GetComponent<Text>().text = "[" + FindWord + "]" + "is found";
        }
        else if (FindWord == "Giant")
        {
            textDisplay.GetComponent<Text>().text = "[" + FindWord + "]" + "is found";
        }
        else if (FindWord == "Suneo")
        {
            textDisplay.GetComponent<Text>().text = "[" + FindWord + "]" + "is found";
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "[" + FindWord + "]" + "not found";
        }


    }
}
