using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : GameManager
{
    public AudioSource jump;
    Rigidbody2D rg;
     float jumpSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        rg = gameMaster.player.GetComponent<Rigidbody2D>();
        jumpSpeed = gameMaster.jumpSpeed;
    }

    private void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.A) && gameMaster.player.isTrigger)
        {
            jump.Play();
            rg.AddForce(Vector2.up * jumpSpeed * 10, ForceMode2D.Impulse);
            gameMaster.player.isTrigger = false;
        }
        
        if (Input.touchCount > 0)
        {
            jump.Play();
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began&& gameMaster.player.isTrigger)
            {
                rg.AddForce(Vector2.up * jumpSpeed * 10, ForceMode2D.Impulse);
                gameMaster.player.isTrigger = false;
            }
        }
    }
    

   
}
