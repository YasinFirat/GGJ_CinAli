using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Singleton benzeri birşey işte 
/// </summary>
public abstract class GameManager : MonoBehaviour
{
    private GameMaster _gameMaster;

    public GameMaster gameMaster
    {
        get
        {
            //Eğer Obje tanımlı değilse tanımla
            if (_gameMaster == null)
            {
                _gameMaster = FindObjectOfType<GameMaster>();
            }
            return _gameMaster;
        }

    }
}
