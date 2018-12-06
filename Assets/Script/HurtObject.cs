using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //När objektet kolliderar med spelaren så händer allt det som står under till.
        if(collision.gameObject.tag == "Player")
        {
            //När spelaren blir träffad så startas level om 
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }

}
