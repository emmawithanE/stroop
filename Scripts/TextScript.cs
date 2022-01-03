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

    public Text guess_display;
    int guesses = 0;
    int correct = 0;

    string correct_guess = "";

    void RerollColour()
    {
        int name_index = Random.Range(0, colour_options.Count);
        int colour_index;

        do
        {
            colour_index = Random.Range(0, colour_options.Count);
        } 
        while (colour_index == name_index);

        GetComponent<Text>().text = colour_options[name_index].name;
        GetComponent<Text>().color = colour_options[colour_index].colour;
        correct_guess = colour_options[colour_index].name;
    }

    // Start is called before the first frame update
    void Start() 
    {
        colour_options.Add(new ColourPair("Black", Color.black));
        colour_options.Add(new ColourPair("Blue", Color.blue));
        colour_options.Add(new ColourPair("Red", Color.red));
        colour_options.Add(new ColourPair("Green", Color.green));

        guess_display.text = $"{correct}/{guesses}";

        RerollColour();
    }

    // Given a "guess" from a button, regenerates the text.
    public void Guess(string input) 
    {
        // If guess is correct (text matches the current text), increment correct
        // Increment guesses either way
        guesses++;
        if (input == correct_guess)
        {
            correct++;
        }

        // Update displayed score in child object
        guess_display.text = $"{correct}/{guesses}";

        RerollColour();
    }
}
