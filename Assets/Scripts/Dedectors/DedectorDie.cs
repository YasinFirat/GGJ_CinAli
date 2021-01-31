using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedectorDie : GameManager
{
    public GameObject restart;
    public GameObject finishGameObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameMaster.SPEEDOFROAD = 0;
        finishGameObject.SetActive(true);
       
    }
}
