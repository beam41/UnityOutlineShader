using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ScreenShotCapture : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            string path = Path.Combine(Application.dataPath, "screenshot", DateTime.Now.ToFileTime() + ".png");
            Debug.Log(path);
            ScreenCapture.CaptureScreenshot(path, 2);
        }
        
    }
}
