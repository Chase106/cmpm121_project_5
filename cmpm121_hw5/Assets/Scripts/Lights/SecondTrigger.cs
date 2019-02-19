using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTrigger : MonoBehaviour
{
    public static bool secondCam;
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
        secondCam = true;
        FirstTrigger.firstCam = false;
        ThirdTrigger.thirdCam = false;
        FourthTrigger.fourthCam = false;
        Debug.Log("ontrigger");
    }
}
