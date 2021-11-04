using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedPlayer;
    private float timer = 0;
    private int randomPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        //Debug.Log(timer);
    }

    private void MovePlayer()
    {
        float axisX = Input.GetAxis("Horizontal");
        float axisZ = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(-axisZ, 0, axisX) * speedPlayer * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        
    }
    private void OnCollisionStay(Collision collision)
    {
        Vector3 wallRandPosition = new Vector3(Random.Range(-5, 5), 2, Random.Range(-5, 5));
        Vector3 wallRandRotation = new Vector3(0, Random.Range(0, 360), 0);
        if (collision.gameObject.name == "Wall")
        {
            timer += Time.deltaTime;
            if (timer > 2f)
            {
                collision.gameObject.transform.position = wallRandPosition;
                collision.gameObject.transform.rotation = Quaternion.Euler(wallRandRotation);
                timer = 0;
            }
        }
    }
}
