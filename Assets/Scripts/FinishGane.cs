using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct DoActive
{
    public GameObject[] obje;
    public bool state;

    public void DoForAll()
    {
        for (int i = 0; i < obje.Length; i++)
        {
            obje[i].SetActive(state);
        }
    }
    public void JustDoIt(int i)
    {
        obje[i].SetActive(state);
    }
}
public class FinishGane : MonoBehaviour
{
    public Animator animator;
    public AnimationClip animationClip;
    public DoActive doNonActive;
    public GameObject restartButton;
  
    
    private void Start()
    {
        doNonActive.DoForAll();
        
        StartCoroutine(animationFinish());
      
    }

    IEnumerator animationFinish()
    {

        float timer = animationClip.length;
       
        while (timer>=0)
        {
            yield return new WaitForFixedUpdate();
            timer -= Time.deltaTime;
        }
        
        while (transform.localScale.x >= 0)
        {
            yield return new WaitForFixedUpdate();
            transform.localScale -= new Vector3(Time.deltaTime*1, Time.deltaTime * 1, 0);
        }

        restartButton.SetActive(true);
        gameObject.SetActive(false);
       
    }
}
