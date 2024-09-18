using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance5 : MonoBehaviour
{
    public GameObject Marker1;
	public GameObject Marker2;

    string guiText = "";
	
	void Update () {
		float distance = Vector3.Distance(Marker1.transform.position, Marker2.transform.position);
        float walid = distance*100;
        guiText = walid.ToString();
		Debug.Log(distance);

	}

    void OnGUI()
    {
        GUIStyle localStyle = new GUIStyle();
        localStyle.normal.textColor = Color.red;
        localStyle.fontSize = 70;
        GUI.Label(new Rect(20, 400, Screen.width - 20, 30), "10cm <-> 10cm : " + guiText +" CM ", localStyle);
    }
}
