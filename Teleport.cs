using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject destinationTeleporter; // the destination Teleporter object

    public void TeleportPlayer(GameObject player)
    {
        player.transform.position = destinationTeleporter.transform.position;
        Debug.Log("Hello, world!");
    }
}
