using UnityEngine;

public class FoodCannon : MonoBehaviour
{
    [SerializeField] private GameObject food;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject newFood =Instantiate(food, transform.position, transform.rotation);
            newFood.GetComponent <Rigidbody>().velocity = Vector3.forward*100;

        }
    }
}
