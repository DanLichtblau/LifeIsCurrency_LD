using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You completed the level!");
            Destroy(gameObject);
        }
    }

    

}
