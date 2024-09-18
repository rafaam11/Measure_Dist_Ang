using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Distance3 : MonoBehaviour
{
    public GameObject Marker1;
	public GameObject Marker2;

    string guiText = "";

	    
	void Update () {
		float distance = Vector3.Distance(Marker1.transform.position, Marker2.transform.position);
        float walid = distance*100;
        guiText = walid.ToString();

        string filePath = Path.Combine(Application.persistentDataPath, "Distance3.txt");    
        string message = guiText;
        WriteTxt(filePath, message);

	}
    void WriteTxt(string filePath, string message) {
    
        DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(filePath));
        if (!directoryInfo.Exists)
        {
            directoryInfo.Create();
        }

        FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
        StreamWriter writer = new StreamWriter(fileStream, System.Text.Encoding.Unicode);
        writer.WriteLine(message);
        writer.Close();

    }

    void OnGUI()
    {
        GUIStyle localStyle = new GUIStyle();
        localStyle.normal.textColor = Color.red;
        localStyle.fontSize = 70;
        GUI.Label(new Rect(20, 250, Screen.width - 20, 30), "3cm <-> 3cm : " + guiText +" CM ", localStyle);
    }


}
