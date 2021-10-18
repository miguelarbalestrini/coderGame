using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int life = 100;
    public float speed = 0f;
    public Vector3 direction = new Vector3(0, 0, 0);
    public int damage = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }
    void MoveBullet()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    int setLife(int life)
    {
        return life;
    }

    void Damage()
    {
        life -= damage;
        print("Te han golpeado.");
        print("Tu vida actual es " + life);
    }
}