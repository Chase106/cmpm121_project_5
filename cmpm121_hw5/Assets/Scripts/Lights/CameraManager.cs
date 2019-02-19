using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject firstTrigger;
    public GameObject secondTrigger;
    public GameObject thirdTrigger;
    public GameObject fourthTrigger;
    public Camera firstCamera;
    public Camera secondCamera;
    public Camera thirdCamera;
    public Camera fourthCamera;
    public bool isFirst;
    public bool isSecond = false;

    // Start is called before the first frame update
    void Start()
    {
        firstCamera.enabled = true;
        secondCamera.enabled = false;
        thirdCamera.enabled = false;
        fourthCamera.enabled = false;

        //secondTrigger = GetComponent<SecondTrigger>();

    }

    // Update is called once per frame
    void Update()
    {
        //isFirst = firstTrigger.GetComponent<FirstTrigger>().firstCam;
        //isSecond = secondTrigger.GetComponent<SecondTrigger>().secondCam;
        if (FirstTrigger.firstCam == true)
        {
            firstCamera.enabled = true;
            secondCamera.enabled = false;
            thirdCamera.enabled = false;
            fourthCamera.enabled = false;
            
            
        }
        if (SecondTrigger.secondCam == true)
        {
            firstCamera.enabled = false;
            secondCamera.enabled = true;
            thirdCamera.enabled = false;
            fourthCamera.enabled = false;
        }
        if (ThirdTrigger.thirdCam == true)
        {
            firstCamera.enabled = false;
            secondCamera.enabled = false;
            thirdCamera.enabled = true;
            fourthCamera.enabled = false;
        }
        if (FourthTrigger.fourthCam == true)
        {
            firstCamera.enabled = false;
            secondCamera.enabled = false;
            thirdCamera.enabled = false;
            fourthCamera.enabled = true;
        }
    }

    
}
