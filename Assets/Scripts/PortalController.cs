using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    [SerializeField] private string nameObject;
    private GameObject player;
    private bool firstTime = true;
    private bool secondTime = false;
    private int count = 0;
    private Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find(nameObject);
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit(Collider collision)
    {
       /* if (collision.gameObject.CompareTag("Player") && firstTime)
        {
            buffSize(player, 0.5f);
            firstTime = false;
            count += 1;

        }
        else if (collision.gameObject.CompareTag("Player") && !firstTime)
        {
            if (originalScale != collision.gameObject.transform.localScale)
            {
                buffSize(player, 2f);
            }
            if (count % 2 == 0)
            {
                firstTime = true;
                count = -1;
            }
            count += 1;
        }*/

       if (collision.gameObject.CompareTag("Player") && firstTime)
        {
            buffSize(player, 0.5f);
            firstTime = false;
            if (secondTime)
            {
                secondTime = false;
            }
        }
        else if (collision.gameObject.CompareTag("Player") &&!firstTime )
        {
            if (secondTime)
            {
                firstTime = true;
            }
            if (originalScale != collision.gameObject.transform.localScale)
            {
                buffSize(player, 2f);
                secondTime = true;
            }
        }
    }

    private void buffSize(GameObject Object, float size)
    {
        Object.transform.localScale *= size;
    }
}
