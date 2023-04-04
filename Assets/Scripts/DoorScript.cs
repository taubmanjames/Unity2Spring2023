using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    public float yVelocity;
    public bool doorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorOpen)
        {
            float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
            transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
        }
    }
}
