using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Måste finnas en rigidbody och att det alltid finns en rigidboy komponent.
[RequireComponent(typeof(Rigidbody2D))]
public class Movment : MonoBehaviour
{
    //Movespeed och jumpheight kan bara var mellan 0 och 20
    [Range(0, 20f)]
    public float movespeed;
    public float jumpHeight;
    public GroundedCheck groundCheck;

    //Läger till en rigidbody vilket är en komponent som ger fysik till det objekt jag har den på.
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame 
    void Update()
    {
        //Gör så att jag kan gå. New Vector betyder att jag måste specifiera en vector x eller y då gör jag en ny specifik vector.
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, rbody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (groundCheck.Touches > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }

    }

}
