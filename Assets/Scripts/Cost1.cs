using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TowerSpawn1.count1 == 1)
        {
            GetComponent<Text>().text = "Cost: " + Tower1.cost2;
        }
    }
}
