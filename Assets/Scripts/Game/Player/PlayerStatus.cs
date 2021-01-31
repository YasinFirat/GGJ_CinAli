using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    public bool isTrigger;
    public Animator animation;
    public Text timerText;


    public void SetTimerText(Text timerText)
    {
        this.timerText = timerText;
    }
     IEnumerator BicycleTime(Create create,Bicycle bicycle)
    {
        float timer=10;
      
        GameMaster.SPEEDOFROAD += GameMaster.BONUSSPEEDOFROAD;
        while (timer>=0)
        {
            
            yield return new WaitForFixedUpdate();
            timer -= Time.deltaTime;
            timerText.text = ((int)timer).ToString();
        }
        GameMaster.SPEEDOFROAD -= GameMaster.BONUSSPEEDOFROAD;
        timerText.text = "0";
        create.DoAllFalse();
        bicycle.currentParts = 0;
        bicycle.RestartCurrent();
        animation.SetBool("Bicycle",false);
      
    }

    public void BuyBicycle(Create create, Bicycle bicycle)
    {
        animation.SetBool("Bicycle",true);
        
        StartCoroutine(BicycleTime(create, bicycle));
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Road"))
        {
            isTrigger = true;
        }
        
    }
}
