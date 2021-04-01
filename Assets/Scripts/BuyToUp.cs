using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyToUp : MonoBehaviour
{
    public GameObject upgrade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TowerSpawn.count == 1)
        {
            upgrade.SetActive(true);
            gameObject.SetActive(false);
        } 
    }
}
