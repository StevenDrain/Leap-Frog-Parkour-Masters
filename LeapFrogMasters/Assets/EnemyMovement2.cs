using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public NavMeshAgent agent;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player2"))
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
        }

    }
}

