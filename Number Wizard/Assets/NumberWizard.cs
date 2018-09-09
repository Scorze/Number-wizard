using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    private int max;
    private int min;
    private int guess;

    // Use this for initialization
    void Start () {
        StartGame();
    }
	

    void StartGame()
    {
        max = 1001;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is:" + max);
        Debug.Log("Lowest number is:" + min);
        Debug.Log("Is your number higher or lower than " + guess + "?");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed it!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
