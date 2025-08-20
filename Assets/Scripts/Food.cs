using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private GameObject smokeEffect;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SmokeEffect),6);
        Destroy(gameObject, 6);
    }

    private void SmokeEffect()
    {
        Instantiate(smokeEffect, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
