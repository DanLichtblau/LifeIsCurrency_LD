using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vet : MonoBehaviour
{

    private bool canEnter = false;
    private bool inShop = false;

    private UIManager uiManager;

    [SerializeField]
    private PlayerControl player;

    //an array of items... 

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }


    void Update()
    {
        if(canEnter == true && player.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                EnterShop();
            }
        }
    }

    public void EnterShop()
    {
        Time.timeScale = 0;
        inShop = true;
        uiManager.EnableVetCavnas();
    }

    public void ExitShop()
    {
        uiManager = FindObjectOfType<UIManager>();
        uiManager.DisableVetCanvas();
        Time.timeScale = 1;
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponentInParent<PlayerControl>().inNeutralZone = true;
            canEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponentInParent<PlayerControl>().inNeutralZone = false;
            canEnter = false;
        }
    }
}
