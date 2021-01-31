using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedectorDisable : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Road"))
            collision.GetComponent<PoolMember>().DisableThis();

        if (collision.CompareTag("Bonus"))
        {
            collision.gameObject.SetActive(false);
        }
       
    }
}
