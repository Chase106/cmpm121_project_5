using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;
    public float rotSpeed = 80;
    public float rot = 0f;
    public float gravity = 8;

    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator anime;

    public GameObject flashlight;
    public bool isFlash = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anime = GetComponent<Animator>();
        //isFlash = GetComponent<Light>().enabled;
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKey(KeyCode.W))
            {
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
                anime.SetBool("IsRun", true);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                moveDir = new Vector3(0, 0, 0);
                anime.SetBool("IsRun", false);
        }
            if (Input.GetKey(KeyCode.S))
            {
                moveDir = new Vector3(0, 0, -1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
                anime.SetBool("IsBack", true);
        }
            if (Input.GetKeyUp(KeyCode.S))
            {
                moveDir = new Vector3(0, 0, 0);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
                anime.SetBool("IsBack", false);
        }
            if (Input.GetKeyDown(KeyCode.F)){
                
                isFlash = !isFlash;
            
            }
            if (isFlash == true)
            {
            flashlight.SetActive(true);

        } else
        {
            flashlight.SetActive(false);
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

    
}
