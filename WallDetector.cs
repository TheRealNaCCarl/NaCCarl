using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour
{
    public bool isCollidingWithWall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            isCollidingWithWall = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Wall")
        {
            isCollidingWithWall = false;
        }
    }
}
