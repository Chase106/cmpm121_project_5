using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCamera : MonoBehaviour
{
    public Transform player;
    public float positionX = 1.073559f;
    public float positionY = 0.675337f;
    public float playerPositionZ;
    public Vector3 firstCamPosition;

    public Vector3 camOffset;

    // Start is called before the first frame update
    void Start()
    {
        //player = GetComponent<Transform>();
        camOffset = transform.position - player.position;
        //camOffset.x = positionX;
        //camOffset.y = positionY;
    }

    // Update is called once per frame
    void Update()
    {
        //playerPositionZ = player.position.z;

        Vector3 firstCamPosition = new Vector3(positionX,positionY,(player.position.z + camOffset.z));
        transform.position = Vector3.Slerp(transform.position, firstCamPosition, 0.5f);
    }
}
