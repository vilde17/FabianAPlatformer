using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //När Player kolliderar med objekt med detta script förstörs objecktet och letar upp alla objekt med LockedDoor och tar bort dem också.
            GameObject[] myDoor = GameObject.FindGameObjectsWithTag("LockedDoor");
            foreach (GameObject item in myDoor)
            {
                Destroy(item);
            }
            Destroy(gameObject);
        }
    }
}

