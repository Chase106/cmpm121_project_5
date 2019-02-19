using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTrigger : MonoBehaviour
{
    public static bool firstCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        firstCam = true;
        SecondTrigger.secondCam = false;
        ThirdTrigger.thirdCam = false;
        FourthTrigger.fourthCam = false;
        Debug.Log("ontrigger");
    }
}
