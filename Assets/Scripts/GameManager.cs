using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int timer=60;
    private void Start()
    {
        InvokeRepeating(nameof(Countdown),1,1);
    }

    private void Countdown()
    {
        timer--;
        print(timer);
    }
}
