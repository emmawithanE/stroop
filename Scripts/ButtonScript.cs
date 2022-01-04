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

    /// Update is called every frame, if the MonoBehaviour is enabled.
    void Update()
    {
        // Button's interactivity should match current state of game_running
        GetComponent<Button>().interactable = TextScript.game_running;
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
