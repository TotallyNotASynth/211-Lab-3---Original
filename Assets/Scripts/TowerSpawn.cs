using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    public static int count = 0;
    public GameObject tower;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        Tower.count = 0;
        TowerSpawn.count = 0;
        Tower.cost = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(TowerSpawn.count == 1)
        {
            Instantiate(tower, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }
}
