using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float speedToLook = 0;
    [SerializeField] private float speedEnemy = 1;
    private enum EnemyType
    {
        Stalker,Follower
    }

    [SerializeField] private EnemyType enemyType;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyType)
        {
            case EnemyType.Stalker:
                LookAtPlayer();
                break;
            case EnemyType.Follower:
                LookAtPlayer();
                if (GetDirection().magnitude >= 2f)
                {
                FollowPlayer(GetDirection());
                }
                break;
        }

    }
    private Vector3 GetDirection()
    {
        return player.transform.position - transform.position;
    }
    private void FollowPlayer(Vector3 direction)
    {
        transform.position += speedEnemy * direction.normalized * Time.deltaTime;
    }

    private void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);
    }
}
