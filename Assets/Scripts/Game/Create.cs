using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : GameManager
{
    float possibility = 30;
    int lastPointNumber;
  
    float weight;
    public Points[] points;

    public Bonus[] bicycle;
  

    private void Start()
    {
        gameMaster.SetBicycle(bicycle.Length);
        possibility = gameMaster.possibility;
        lastPointNumber = 0;
       
        
        weight = gameMaster.startWeightRoad;
        Vector2 size = new Vector2(weight, 1);
        GameObject g = gameMaster.CallObjectInsidePool(PoolMemberId.road, (points[0].getPosition()));
        SpriteRenderer s = g.GetComponent<SpriteRenderer>();

        s.size = size;
    }
    void CreateBonus(Vector2 position)
    {
        bicycle[Random.Range(0, bicycle.Length)]
            .CreateBonus(position,possibility);
    }

    public void CreateRoad()
    {
        lastPointNumber = lastPointNumber == 0 ? Random.Range(0, 2) : Random.Range(0, points.Length);
        weight = Random.Range(gameMaster.minWeightOfRoad, gameMaster.maxWeightOfRoad);
        Vector2 size = new Vector2(weight, 1);
        GameObject g = gameMaster
            .CallObjectInsidePool(PoolMemberId.road, (points[lastPointNumber].getPosition() + Vector2.right * weight / 2));
        SpriteRenderer s = g.GetComponent<SpriteRenderer>();

        s.size = size;

        CreateBonus(g.transform.position+Vector3.up);
    }
}
