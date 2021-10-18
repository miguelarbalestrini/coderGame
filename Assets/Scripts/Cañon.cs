using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo",0f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("Disparo", 0f);
        }*/

        /*if (Input.GetKeyDown(KeyCode.J))
        {
            Invoke("Disparo", 0f);
            Invoke("Disparo", 0.25f);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Invoke("Disparo", 0f);
            Invoke("Disparo", 0.25f);
            Invoke("Disparo", 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Invoke("Disparo", 0f);
            Invoke("Disparo", 0.25f);
            Invoke("Disparo", 0.5f);
            Invoke("Disparo", 0.75f);
        }*/
    }

    void Disparo()
    {
        Instantiate(bullet,transform);
    }

}
