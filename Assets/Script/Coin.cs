using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{  
    //Säger att det objekt som har detta scriptet lägger till ett poäng.
    public int score = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // Skapa en tämporär variabel "controller" och sätt den till resultatet av sökningen efter objektet med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //Skapa en tämporär variabel "tracker" och sätt den till resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += score;
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            else
            {
                //Om GameController inte finns skickas en error och den måste vara på och den kan inte bli bort taggen.
                Debug.LogError("GameController finns inte");
            }
            //Förstör objecktet efter att alla andra sak ovanför har hänt.
            Destroy(gameObject);
        }
    }

}
