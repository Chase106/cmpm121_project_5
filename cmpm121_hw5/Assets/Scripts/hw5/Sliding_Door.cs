using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding_Door : MonoBehaviour
{
    public GameObject DoorTrigger;
    public GameObject Left_Door;
    public GameObject Right_Door;
    public GameObject Gold;

    Animator leftAnime;
    Animator rightAnime;

    //bool pickUp;
    string player_recog = "Characte";
    // Start is called before the first frame update
    void Start()
    {
        leftAnime = Left_Door.GetComponent<Animator>();
        rightAnime = Right_Door.GetComponent<Animator>();
        //pickUp = Gold.GetComponent<Pickup_item>().isPick;
    }

    // Update is called once per frame

    void Update()
    {
        if (Gold.GetComponent<Pickup_item>().isPick == true)
        {
            player_recog = "Character";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == player_recog)
        {
            SlideDoor(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == player_recog)
        {
            SlideDoor(false);
        }
    }

    void SlideDoor(bool state)
    {
        leftAnime.SetBool("slide", state);
        rightAnime.SetBool("slide", state);
    }
}
