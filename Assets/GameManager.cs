using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    GameObject container = new GameObject("Bicycle");
                    _instance = container.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }

    [Header("Shape")]
    public GameObject torus;
    public GameObject cube;
    public GameObject teapot;
    public GameObject stair;

    [Header("Setting")]
    public float tMovSpeed = 20f;

    public void EnableTorus()
    {
        torus.SetActive(true);
        cube.SetActive(false);
        teapot.SetActive(false);
        stair.SetActive(false);
    }

    public void EnableCube()
    {
        torus.SetActive(false);
        cube.SetActive(true);
        teapot.SetActive(false);
        stair.SetActive(false);
    }

    public void EnableTeapot()
    {
        torus.SetActive(false);
        cube.SetActive(false);
        teapot.SetActive(true);
        stair.SetActive(false);
    }

    public void EnableStair()
    {
        torus.SetActive(false);
        cube.SetActive(false);
        teapot.SetActive(false);
        stair.SetActive(true);
    }

    public void changeSpeed(float value)
    {
        tMovSpeed = value;
    }
}
