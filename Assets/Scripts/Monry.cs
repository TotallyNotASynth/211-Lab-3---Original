﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monry : MonoBehaviour
{
    public static int money = 10;
    // Start is called before the first frame update
    void Start()
    {
        money = 10;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Money: " + money;
    }
}
