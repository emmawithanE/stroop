using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public string txt;
    public Text target;
    Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox = transform.Find("Text").GetComponent<Text>();
        textbox.text = txt;
    }

    // Run from outside to change button text
    public void ChangeText(string input)
    {
        txt = input;
        textbox.text = txt;
    }

    // Sets button text, run on click
    public void Clicked()
    {
        target.GetComponent<TextScript>().Guess(txt);
    }
}
