using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceObject : GameManager
{


    // Update is called once per frame
    void FixedUpdate()
    {
       
        transform.position -= new Vector3(GameMaster.SPEEDOFROAD*Time.deltaTime, 0, 0);
    }
}
