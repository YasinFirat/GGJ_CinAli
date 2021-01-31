using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct BonusObje
{
    public GameObject obje;
    public bool isTake;

    public void Create(Vector2 position)
    {
        if (!isTake)
        {
            obje.SetActive(true);
            obje.transform.position = position;
        }
    }
}


public class Bonus : GameManager
{
    public BonusObje bonusObje;
    private void Start()
    {
        bonusObje.obje = this.gameObject;
    }
   

    /// <summary>
    /// Olası durum yani possibility gerçekleştiğinde random bir id atanır eğer bu id'ye ait obje daha önceden oluşturulmadıysa oluşturulur.
    /// Eğer oluşturulduysa bir dahaki olasılık tutturulunca tekrar dener.
    /// </summary>
    public void CreateBonus(Vector2 position,float possibility)
    {
        if(Random.Range(0,100)<= possibility)
        {
            bonusObje.Create(position);
        }
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameMaster.bicycle.AddPart();
            bonusObje.isTake = true;
            this.gameObject.SetActive(false);
            gameMaster.CanIBuyBycle();
            
        }
    }
}
