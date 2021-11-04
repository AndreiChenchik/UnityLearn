using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 5, -7);
    private Vector3 cameraAngle = new Vector3(30, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Sync camera with player
        transform.forward = player.transform.forward;
        transform.position = player.transform.position;

        // Offset camera back 
        transform.Translate(cameraOffset, Space.Self);
        transform.Rotate(cameraAngle);
    }
}
