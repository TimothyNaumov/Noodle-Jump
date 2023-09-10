using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        if(player.position.y > transform.position.y) {
            Vector3 camera = transform.position;
            camera.y = player.position.y;
            transform.position = camera;
        }
    }
}
