using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent enemy;
    public Transform PlayerTarget;

    private void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(PlayerTarget.position);
    }
}
