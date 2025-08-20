using UnityEngine;

public class FoodCannon : MonoBehaviour
{
    [SerializeField] private GameObject food;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float shootPower;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject newFood =Instantiate(food, shootPoint.position, shootPoint.rotation);
            newFood.GetComponent<Rigidbody>().velocity = shootPoint.TransformDirection(Vector3.forward * shootPower);

        }
    }
}
