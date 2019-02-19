using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pickup_item : MonoBehaviour
{
    public bool isPick;
    public int count;
    public GameObject pickEffect;
    public GameObject changeScene;
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
        if (other.gameObject.tag == "Character")
        {
            isPick = true;
            changeScene.GetComponent<Pickup_other>().count ++;
            Instantiate(pickEffect, transform.position, transform.rotation);
            gameObject.SetActive(false);
            //Destroy(gameObject);

        }
    }
}
