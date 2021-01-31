using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PoolMemberId
{
    road,
}

public class GameMaster : MonoBehaviour
{
    [Header("Road")]
    public float speedOfRoad;
    public float bonusSpeedOfRoad;
    public float bonusScore;
    public float startWeightRoad;
    [Range(4,7)]
    public float minWeightOfRoad;
    [Range(7,20)]
    public float maxWeightOfRoad;
    public float possibility; 
    public static float SPEEDOFROAD;
    public static float BONUSSPEEDOFROAD;
    public static float BONUSSCORE;
    [Header("Player")]
    public PlayerStatus player;
    public float jumpSpeed;
    [Header("Canvas")]
    public Text textOfParts;
    public Text timerText;
    public Text textScore;
    public Text hightScore;
    [Header("Others")]
    public Bicycle bicycle;
    public Score score;
    
    
    [Header("Pooling")]
    [Tooltip("Yeni Bir Pool objesi ekleyeceğiniz zaman script içine gelip enum değerlerini düzeltmeniz gerekecek")]
    public GameObject prefabGroups;
    public Pooling[] poolings;

    private void Awake()
    {
        score = new Score();
        SPEEDOFROAD = speedOfRoad;
        BONUSSPEEDOFROAD = bonusSpeedOfRoad;
        
        player.SetTimerText(timerText);
       
        for (int i = 0; i < poolings.Length; i++)
        {
            poolings[i].FillPool(i);
        }
    }
    public void SetBicycle(int totalParts)
    {
        bicycle = new Bicycle(textOfParts, totalParts);
    }
    public void CanIBuyBycle()
    {
        if (bicycle.canIBuy)
        {
            player.BuyBicycle();
           
        }
    }
    /// <summary>
    /// Obje çıkartıldığı havuz'a geri gider.
    /// </summary>
    /// <param name="poolMemberId">Üye olduğu Havuz'un Numarası</param>
    /// <param name="gameObject">Havuza gitmesi gereken obje</param>
    public void GoYourPool(PoolMemberId poolMemberId, GameObject gameObject)
    {
        poolings[(int)poolMemberId].AddPool(gameObject);
    }
    /// <summary>
    /// Havuz'dan obje alınır.
    /// </summary>
    /// <param name="poolMemberId">Havuz'un id numarası</param>
    /// <param name="_position"> çağrılacağı pozisyon</param>
    /// <returns></returns>
    public GameObject CallObjectInsidePool(PoolMemberId poolMemberId, Vector3 _position)
    {
        return poolings[(int)poolMemberId].CallMember(_position);
    }
    /// <summary>
    /// Oyun Bittiğinde Çağrılır.
    /// </summary>
    public void EndGame()
    {
        prefabGroups.SetActive(false);
    }

    /// <summary>
    /// Oyun Başladığında çağrılır.
    /// </summary>
    public void StartGame()
    {
        prefabGroups.SetActive(true);
    }
}
