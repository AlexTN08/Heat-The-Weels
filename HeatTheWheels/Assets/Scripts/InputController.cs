using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputController : MonoBehaviour
{
    private string inputHorizontaAxis = "Horizontal";
    private string inputVerticalAxis = "Vertical";


    public float ThrottelInput { get; private set; } //Throttel = A regula
    public float SteerInput { get; private set; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SteerInput = Input.GetAxis(inputHorizontaAxis);
        ThrottelInput = Input.GetAxis(inputVerticalAxis);

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);// press R to reload scene 1
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }

    }
        
}
