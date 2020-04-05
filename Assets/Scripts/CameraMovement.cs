using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rotSpeed = 1.5f;
    private bool lastFrameMove = false;
    private Vector3 lFMousePos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 mousePos = Input.mousePosition;
            if (lastFrameMove)
            {
                Vector3 deltaMousePos = lFMousePos - mousePos;
                deltaMousePos = deltaMousePos * rotSpeed * Time.deltaTime;
                transform.Rotate(deltaMousePos.y, -deltaMousePos.x, 0);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);

            }
            lFMousePos = mousePos;
            lastFrameMove = true;
        }
        else
        {
            lastFrameMove = false;
        }
        
    }
}
