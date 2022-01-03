using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourPair
{
    public string name;
    public Color colour;

    public ColourPair(string name_input, Color colour_input)
    {
        name = name_input;
        colour = colour_input;
    }
}

public class TextScript : MonoBehaviour
{
    List<ColourPair> colour_options = new List<ColourPair>();
    Color green = Color.green;

    // Start is called before the first frame update
    void Start() {
        GetComponent<Text>().text = "new text";

        colour_options.Add(new ColourPair("Black", Color.black));
        colour_options.Add(new ColourPair("Blue", Color.blue));
        colour_options.Add(new ColourPair("Red", Color.red));
        colour_options.Add(new ColourPair("Green", Color.green));

        Debug.Log(colour_options.Count);
    }

    // Given a "guess" from a button, regenerates the text.
    public void Guess(string input) {

        // By spec, two random ints cannot be the same
        int name_index = Random.Range(0,4);
        int colour_index;

        do {
            colour_index = Random.Range(0,4);
        } 
        while (colour_index == name_index);

        GetComponent<Text>().text = colour_options[name_index].name;
        GetComponent<Text>().color = colour_options[colour_index].colour;

        Debug.Log($"Reroll: name {name_index}, colour {colour_index}");
    }
}
