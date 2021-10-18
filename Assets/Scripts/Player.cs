using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int life = 100;
    public float speed = 0f;
    public Vector3 direction = new Vector3(0, 0, 0);
    public int heal = 0;
    public int hitDamage = 0;


    // Start is called before the first frame update
    void Start()
    {
        setLife(life);
        print("HP:" + life);

        //Descomentar para probar las funicones una unica vez.
        //Healing();
        //Damage();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        // Descomentar para probar funciones infinitamente dentro del update.
        //Healing();
        //Damage();
    }

    void MovePlayer()
    {
        transform.position = direction * speed++;
    }

    int setLife(int life)
    {
        return life;
    }

    void Healing()
    {
        life += heal;
        print("Te has curado");
        Debug.Log( "Tu vida actual es " + life);
    }

    void Damage()
    {
        life -= hitDamage;
        print("Te han golpeado.");
        Debug.Log("Tu vida actual es " + life);
    }
}
