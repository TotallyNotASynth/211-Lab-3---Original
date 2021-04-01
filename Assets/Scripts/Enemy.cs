using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rbs;
    public Sprite[] type;
    SpriteRenderer sr;

    public AudioClip hit;

    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, 3);
        rbs = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        sr. sprite = type[randomIndex];
        if (sr.sprite == type[0])
        {
            rbs.velocity = new Vector2(0f, -1f);
        }
        else if (sr.sprite == type[1])
        {
            rbs.velocity = new Vector2(0f, -2f);
        }
        else if (sr.sprite == type[2])
        {
            rbs.velocity = new Vector2(0f, -3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 6 || transform.position.y < -6)
        {
            Destroy(gameObject);
            EnemySpawn.deaths++;
        }
        if (transform.position.x >= 9 || transform.position.x < -9)
        {
            Destroy(gameObject);
            EnemySpawn.deaths++;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            GetComponent<AudioSource>().PlayOneShot(hit);
            Destroy(gameObject);   
        }
    }
}
