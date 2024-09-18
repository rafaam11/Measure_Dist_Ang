using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    
    public int theScore = 0;

	void Update () {
        //These two lines are all there is to the actual movement..
        float moveInput = Input.GetAxis("Horizontal") * Time.deltaTime * 3; 
        transform.position += new Vector3(moveInput, 0, 0);

        //Restrict movement between two values
        if (transform.position.x <= -3.0f || transform.position.x >= 3.0f)
        {
            float xPos = Mathf.Clamp(transform.position.x, -3.0f, 3.0f); //Clamp between min -2.5 and max 2.5
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
	}

    //OnGUI is called multiple times per frame. Use this for GUI stuff only!
    void OnGUI()
    {
        //We display the game GUI from the playerscript
        //It would be nicer to have a seperate script dedicated to the GUI though...

		GUIStyle guiStyle = new GUIStyle(); //create a new variable
		guiStyle.fontSize = 20; //change the font size
		guiStyle.normal.textColor = Color.red;

		GUILayout.Label("Score: " + theScore, guiStyle);
    }    
}
