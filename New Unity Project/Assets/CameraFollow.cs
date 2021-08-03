using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Update is called once per fram
    public Transform player;
    private Quaternion myRotation;
    void Start() 
    {
        myRotation = transform.rotation;
    }
    void Update()
    {
        transform.position = new Vector3 (Mathf.Clamp(player.position.x, 0, 32), Mathf.Clamp(player.position.y, 0, 15), -1);
        transform.rotation = myRotation;
    }
}
