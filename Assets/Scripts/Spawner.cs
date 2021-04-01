using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemies;
    float timeCheck = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCheck += Time.deltaTime;
        if (timeCheck >= 0.5f)
        {
            //int randomIndex = Random.Range(0, 3);
            GameObject bulletsSpawn = Instantiate(enemies, transform.position, transform.rotation);
            timeCheck = 0;
        }
        
    }
}
