using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTrigger : MonoBehaviour
{
    public GameObject colorLight;
    public static bool thirdCam;
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
        FirstTrigger.firstCam = false;
        SecondTrigger.secondCam = false;
        thirdCam = true;
        FourthTrigger.fourthCam = false;
        Debug.Log("ontrigger");
        colorLight.SetActive(false);
    }

}
