using UnityEngine;
using System.IO;

// string filePath = Application.persistentDataPath + "/filecreate";

public class txtCreate : MonoBehaviour
{   
    void Awake() {
        string filePath = Path.Combine(Application.persistentDataPath, "Example.txt");    
        string message = "I love me !!";
        WriteTxt(filePath, message);
    }

    void Update () {
        string filePath = Path.Combine(Application.persistentDataPath, "Example.txt");    
        string message = "I love me !!";
        WriteTxt(filePath, message);

        /*
        if (Input.GetKeyDown(KeyCode.R))
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, "Example.txt");
            Debug.Log(ReadTxt(filePath));
        }
        */
	}  
	    
	
    void WriteTxt(string filePath, string message) {
    
        DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(filePath));

        if (!directoryInfo.Exists)
        {
            directoryInfo.Create();
        }

        FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

        StreamWriter writer = new StreamWriter(fileStream, System.Text.Encoding.Unicode);

        writer.WriteLine(message);
        writer.Close();
    }
    string ReadTxt(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        string value = "";

        if (fileInfo.Exists)
        {
            StreamReader reader = new StreamReader(filePath);
            value = reader.ReadToEnd();
            reader.Close();           
        }

        else
            value = "파일이 없습니다.";

        return value;
    }
}
