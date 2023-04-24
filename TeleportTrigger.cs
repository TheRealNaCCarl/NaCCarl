using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public Teleport teleporter; // the Teleporter object

    private void Collider2D(Collision2D other)
    {
        Debug.Log("Hello, world!");
        if (other.gameObject.tag == "Player")
        {
            teleporter.TeleportPlayer(other.gameObject);
            Debug.Log("Hello, world!");
        }
    }
}
