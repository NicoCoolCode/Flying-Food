using UnityEngine;

public class CroissantSpawner : MonoBehaviour
{
    [SerializeField] private GameObject croissant;
    public void SpawnCroissants()
    {
        
        for (int i = 0; i < 5; i++)
        {
            Instantiate(croissant, transform.position+ new Vector3(Random.Range(-5,5), 0, 0), transform.rotation);
        }
    }

    private void Start()
    {
        SpawnCroissants();
    }
}
