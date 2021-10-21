using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private int life = 100;
    public float speed = 0f;
    public Vector3 direction = new Vector3(0, 0, 0);
    public int damage = 0;
    public float timeBullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();

        DestroyBullet(timeBullet);

        ScaleBullet();
        
        timeBullet -= Time.deltaTime;
    }
    void MoveBullet()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    void Damage()
    {
        life -= damage;
        print("Te han golpeado.");
        print("Tu vida actual es " + life);
    }
    void DestroyBullet(float time)
    {
        if (time < 0)
        {
            Destroy(gameObject);
        }
    }
    void ScaleBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale *= 2;
        }
    }
}