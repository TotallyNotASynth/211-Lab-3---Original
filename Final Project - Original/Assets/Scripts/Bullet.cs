using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rbs;

    public AudioClip hit;

    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 6 || transform.position.y < -6)
        {
            Destroy(gameObject);
        }
        if (transform.position.x >= 9 || transform.position.x < -9)
        {
            Destroy(gameObject);
        }
        rbs.velocity = (transform.up * 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "enemy")
        {
            GetComponent<AudioSource>().PlayOneShot(hit);
            Debug.Log("hit");
            
            KillCount.kills++;
            EnemySpawn.deaths++;
            Monry.money += 1;
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
