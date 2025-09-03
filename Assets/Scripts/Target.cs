using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform spawnPointParent;
    [SerializeField] private GameObject hitEffect;
    [SerializeField] private GameObject appearEffect;
    private List<Transform> allSpawns = new List<Transform>();

    private void Awake()
    {
        GetSpawns();
    }

    private void GetSpawns()
    {
        foreach (Transform spawnPoint in spawnPointParent)
        {
            allSpawns.Add(spawnPoint);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Move();
    }

    private void Move()
    {
        Instantiate(hitEffect,transform.position,transform.rotation);
        Transform randomSpawn;
        do
        {
             randomSpawn = allSpawns[Random.Range(0, allSpawns.Count)];
        } while (randomSpawn.position.Equals(transform.position));
        transform.SetPositionAndRotation(randomSpawn.position, randomSpawn.rotation);
        Instantiate(appearEffect, transform.position, transform.rotation);
    }
}
