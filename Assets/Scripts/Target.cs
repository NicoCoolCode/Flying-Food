using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform spawnPointParent;
    private List<Transform> allSpawns = new List<Transform>();
    private string ichBinVerfuegbar;
    private void Awake()
    {
        GetSpawns();
        string ichBinUnsichtbarMuahahaha;
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
        Transform randomSpawn = allSpawns[Random.Range(0,allSpawns.Count)];
        transform.SetPositionAndRotation

    }
}
