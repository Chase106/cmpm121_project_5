using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthTrigger : MonoBehaviour
{
    public static bool fourthCam;
    public GameObject colorLight;
    // Start is called before the first frame update
    void Start()
    {
        colorLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        FirstTrigger.firstCam = false;
        SecondTrigger.secondCam = false;
        ThirdTrigger.thirdCam = false;
        fourthCam = true;
        Debug.Log("ontrigger");
        colorLight.SetActive(true);
    }
}
