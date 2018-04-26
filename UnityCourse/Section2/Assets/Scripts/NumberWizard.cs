using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {


    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start () {

        StartGame();

        

    }

    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max = max + 1;

        print("========================");
        print("Welcome to Mumber Wizard");
        print("Pick a Number in your Head but don't tell me!");



        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess);
        print("Press 'UP' for higher 'DOWN' for lower and 'SPACE' for equal");

    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Press 'UP' for higher 'DOWN' for lower and 'SPACE' for equal");
    }
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("UP key was pressed");
            min = guess;
            NextGuess();

        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("DOWN key was pressed");
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won");
            StartGame();
        }
    }
}
