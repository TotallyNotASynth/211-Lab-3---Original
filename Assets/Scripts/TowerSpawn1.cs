using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn1 : MonoBehaviour
{
    public static int count1 = 0;
    public GameObject tower;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        Tower1.countT2 = 0;
        TowerSpawn1.count1 = 0;
        Tower1.cost2 = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(TowerSpawn1.count1 == 1)
        {
            Instantiate(tower, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }
}
