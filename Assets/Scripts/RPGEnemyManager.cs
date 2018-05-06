using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGEnemyManager : Manager<RPGEnemyManager>
{

    // Object Pool
    // used to reduce runtime memory allocation by reusing objects then setting them as inactive when
    // not being used.
    static private List<GameObject> enemyPool;
    public GameObject enemyPrefab;
    public int poolSize;

    public GameObject SpawnEnemy()
    {
        print("called spawn enemy");
        foreach (GameObject enemy in enemyPool)
        {
            if (enemy.activeSelf == false)
            {
                enemy.SetActive(true);
                return enemy;
            }
        }
        return null;
    }

    public override void Awake()
    {
        print("awaking enemy manager");
        base.Awake();

        if (enemyPool == null)
        {
            enemyPool = new List<GameObject>();
        }

        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemyObj = (GameObject)Instantiate(enemyPrefab);
            enemyObj.SetActive(false);
            enemyPool.Add(enemyObj);
        }
    }

    protected void OnDestroy()
    {
        //enemyControllers.Remove(this);

        //if (enemyControllers.Count == 0)
        //{
        //    enemyControllers = null;
        //}
    }

    protected void OnBecameInvisible()
    {
        //gameObject.SetActive(false);
    }

}
