using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Collabedit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/Resources/test.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Test");
        //writer.Flush();
        writer.Close();

        path = "Assets/Resources/test.txt";
        // dont write shit.
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
