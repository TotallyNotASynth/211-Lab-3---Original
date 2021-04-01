using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1 : MonoBehaviour
{
    public Sprite[] levels;
    public GameObject[] bullets;
    public static int countT2 = 0;
    int count2 = 1;
    float speed = 110f;
    float quickTimer = 0f;
    Rigidbody2D rbs;

    public static int cost2 = 10;

    public AudioClip firing;

    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Tower1.countT2 == count2)
        {
            if (Tower1.countT2 <= 9)
            {
                GetComponent<SpriteRenderer>().sprite = levels[countT2];
                speed -= 10;
                count2++;
                cost2 += 5;
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
