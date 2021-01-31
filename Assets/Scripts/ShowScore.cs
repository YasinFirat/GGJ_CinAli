using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : GameManager
{
    public Text textScore;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        textScore = gameMaster.textScore;
    }

    // Update is called once per frame
    void Update()
    {
        timer += GameMaster.SPEEDOFROAD*Time.deltaTime;
        textScore.text ="Score: "+ (int)timer;
    }
    private void OnDisable()
    {
        gameMaster.score.CalculateHightScore((int)timer);
        gameMaster.hightScore.text ="Hight Score: "+ gameMaster.score.GetHightScore();
    }
}
