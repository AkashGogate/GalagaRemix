using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class enemySpawn : MonoBehaviour
{
    //public GameObject[] enemies;
    public GameObject enemy;
    public Transform spawn;
    public float gameTime;

    // Start is called before the first frame update
    void Start()
    {

    }

        // Update is called once per frame
        void Update()
        {
        StartCoroutine(SpawnEnemies());

        }

    IEnumerator SpawnEnemies()
    {
        gameTime += Time.deltaTime;

        if (gameTime % 5 < 0.01f && GameObject.Find("Enemy(Clone)") == null)
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject go = (GameObject)Instantiate(enemy, new Vector3(Random.Range(-10f,10f), 0.5f, -13.52f - i * 4), Quaternion.identity);
                go.transform.Rotate(0, 0, 2);
                yield return new WaitForSeconds(0.5f);


            }

        }
    }
}
