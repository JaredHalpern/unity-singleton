using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGGameManager : Manager<RPGGameManager>
{
    //public static RPGGameManager gameManager = null;
    RPGEnemyManager enemyManager;

    public override void Awake()
    {
        base.Awake();
        enemyManager = RPGEnemyManager.sharedInstance;
        enemyManager = RPGEnemyManager.sharedInstance;
        enemyManager = RPGEnemyManager.sharedInstance;
        enemyManager = RPGEnemyManager.sharedInstance;
        enemyManager = RPGEnemyManager.sharedInstance;

    }

    private void Start()
    {
        InitGame();
    }

    void InitGame()
    {
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        enemyManager.SpawnEnemy();
    }

}
