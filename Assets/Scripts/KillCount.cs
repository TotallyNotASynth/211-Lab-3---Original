using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
    public static int kills = 0;
    // Start is called before the first frame update
    void Start()
    {
        kills = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Kills: " + kills;
    }
}
