using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public Sprite[] levels;
    public GameObject[] bullets;
    public static int count = 0;
    int count2 = 1;
    float speed = 110f;
    float quickTimer = 0f;
    Rigidbody2D rbs;

    public static int cost = 10;

    public AudioClip firing;

    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Tower.count == count2)
        {
            if(Tower.count <= 9)
            {
                GetComponent<SpriteRenderer>().sprite = levels[count];
                speed -= 10;
                count2++;
                cost += 5;
            }  
        }
        quickTimer++;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            //Debug.Log("enemy sighted");
            
            if(quickTimer >= speed)
            {
                //Debug.Log("firing");
                int randomIndex = Random.Range(0, 4);
                GetComponent<AudioSource>().PlayOneShot(firing);
                GameObject bulletsSpawn = Instantiate(bullets[randomIndex], transform.position, transform.rotation);
                quickTimer = 0f;
            } 
        }
    }
}
