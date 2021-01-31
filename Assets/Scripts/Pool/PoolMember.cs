using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolMember : GameManager
{
    public int MemberId;
    public bool isFirstRun = true;

    public void DisableThis()
    {
        gameMaster.poolings[MemberId].AddPool(this.gameObject);
        gameObject.SetActive(false);
    }

   

    private void OnDisable()
    {//obje ilk oluşturulduğu zaman OnDisable çalıştığından dolayı ilk kurulumda 
        //aşağıdaki kod satırını çalışmasını öncelemek amacıysa bu if yapısı kullanıldı
        //if (isFirstRun)
        //{
        //    isFirstRun = false;
        //    return;
        //}

        //obje yok olduğunda kendi listesine geri döner
       

    }
}
