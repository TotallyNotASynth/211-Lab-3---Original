using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemies;
    float timeCheck = 0f;

    public static int waveNum = 1;
    int nextWave = 10;
    public static int deaths = 0;
    int spawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        deaths = 0;
        waveNum = 1;
    }
    // Update is called once per frame
    void FixedUpdate()
{
        timeCheck += Time.deltaTime;

        if (deaths < nextWave)
        {
            if (timeCheck >= 0.5f && spawned < nextWave)
            {
                //int randomIndex = Random.Range(0, 3);
                GameObject bulletsSpawn = Instantiate(enemies, transform.position, transform.rotation);
                timeCheck = 0;
                spawned++;
            }
        }
        else
        {
            if (timeCheck >= 1f)
            {
                Debug.Log(deaths);
                waveNum++;
                nextWave = waveNum * 10;
                Debug.Log("next"); 
                deaths = 0;
                spawned = 0;
            }
        }

        if (waveNum > 10)
        {
            SceneManager.LoadScene("End");
        }
    }
}
