using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TowerSpawn.count == 1)
        {
            GetComponent<Text>().text = "Cost: " + Tower.cost;
        }
    }
}
