using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pickup_other : MonoBehaviour
{
    public int count;
    public GameObject cameraManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (count == 3)
        {

            cameraManager.GetComponent<CameraManager>().firstCamera.enabled = true;
            cameraManager.GetComponent<CameraManager>().secondCamera.enabled = false;
            cameraManager.GetComponent<CameraManager>().thirdCamera.enabled = false;
            cameraManager.GetComponent<CameraManager>().fourthCamera.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
