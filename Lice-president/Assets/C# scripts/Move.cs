using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform EndPoint;
    public Transform BadGuy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, BadGuy.position) < Vector3.Distance(transform.position, EndPoint.position))
        {
            var heading = BadGuy.position - transform.position;
            transform.position = Vector3.MoveTowards(transform.position, BadGuy.position, 1);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, 1);
        }
    }
}
