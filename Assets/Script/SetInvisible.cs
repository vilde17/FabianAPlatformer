using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{
    //Gör så att de object som har detta scriptet blir osynliga vilket den gör genom att den sätter att spriterenderern på objektet inte är eneblad
    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
