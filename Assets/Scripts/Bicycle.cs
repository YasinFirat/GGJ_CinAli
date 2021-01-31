using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bicycle
{
    public int totalParts;
    public int currentParts=0;
    public bool canIBuy;
    private Text textOfParts;


   public Bicycle(Text text, int totalParts)
    {
        this.totalParts = totalParts;
        textOfParts = text;
        textOfParts.text = currentParts + "/" + totalParts;
    }
    public void AddPart()
    {
        currentParts++;
        textOfParts.text = currentParts + "/" + totalParts;
        if (currentParts == totalParts)
        {
            canIBuy = true;
        }
    }

}
