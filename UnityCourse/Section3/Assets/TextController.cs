using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
    private States myState;

	// Use this for initialization
	void Start () {
        text.text = "Hello";
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.cell)
        {
            state_cell();
        }
	}

    void state_cell ()
    {
        text.text = "This is a Game\n\n" +
                    "Press S to view Sheets, M to view Mirror, L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
    }
}
