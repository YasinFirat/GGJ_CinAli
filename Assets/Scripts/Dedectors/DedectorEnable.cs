using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedectorEnable : MonoBehaviour
{
    public Create create;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Road"))
            return;

        create.CreateRoad();
    }
}
