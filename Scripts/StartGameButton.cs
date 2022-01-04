using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    public GameObject game_ui;
    public GameObject hide_ui;
    public Text colour_text;

    public void StartGame()
    {
        game_ui.SetActive(true);
        colour_text.GetComponent<TextScript>().ResetGame();
        hide_ui.SetActive(false);
    }
}
