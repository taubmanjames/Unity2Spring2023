using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointEnemy : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;
    Vector3 targetPos;
    [SerializeField]
    [Range(0, 1)]
    float moveSpeed = 0;
    int wayPointIndex;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = waypoints[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, 0.5f * moveSpeed);

        if (Vector3.Distance(transform.position, targetPos) < 0.3f)
        {
            if (wayPointIndex >= waypoints.Length - 1)
            {
                wayPointIndex = 0;
            }
            else
            {
                wayPointIndex++;
            }
            targetPos = waypoints[wayPointIndex].position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(10.0f);
        }
    }
}
