using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelNumChange1 : MonoBehaviour
{
    int count2 = 1;
    int count3 = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Tower1.countT2 == count2 && count3 <= 10)
        {
            GetComponent<Text>().text = "Level " + count3;
            count2++;
            count3++;
        }
        else if (TowerSpawn1.count1 == 1 && Tower1.countT2 == 0)
        {
            GetComponent<Text>().text = "Level 1";
        }
    }
}
