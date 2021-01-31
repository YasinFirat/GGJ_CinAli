using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Animator animator;
    public AnimationClip animationClip;

    public GameObject afterClipOpen;
   

    private void Start()
    {

        StartCoroutine(animationFinish());

    }

    IEnumerator animationFinish()
    {

        float timer = animationClip.length;
        
        while (timer >= 0)
        {
            yield return new WaitForFixedUpdate();
            timer -= Time.deltaTime;
        }

        afterClipOpen.SetActive(true);
        gameObject.SetActive(false);
       
    }
}
