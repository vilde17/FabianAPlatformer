using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck : MonoBehaviour
{   //Variabel som att det finns en sak som vissar om jag rör marken eller inte
    public int Touches;
    //Säger att vi colliderer med marken
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Touches++;
    }
    //Säger att vi inte collider med marken
    private void OnTriggerExit2D(Collider2D collision)
    {
        Touches--;
    }

}
