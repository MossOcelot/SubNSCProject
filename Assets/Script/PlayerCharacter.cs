using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    // Start is called before the first frame update

    private int score;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Item"))
        {
            Destroy(target.gameObject);
            score += 10;
            Debug.Log(score);
        }
    }


}
