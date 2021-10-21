using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour
{
    public GameObject bullet;
    public float initialTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo", initialTime, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Disparo()
    {
        Instantiate(bullet, transform);
    }
}
