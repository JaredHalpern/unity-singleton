using System.Collections;
using UnityEngine;

public class Preloader : MonoBehaviour
{
    //RPGEnemyManager enemyManager;
    RPGGameManager gameManager;

    public void Awake()
    {

        if (RPGGameManager.sharedInstance == null)
        {
            print("why am i called?");
            //enemyManager = RPGGameManager.sharedInstance;
        }
    }
}