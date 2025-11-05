using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int timer=60;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text timesUpText;
    private void Start()
    {
        InvokeRepeating(nameof(Countdown),1,1);
        timerText.text = "timer; "+  timer.ToString();
    }

    private void Countdown()
    {   
        timer--;
        timerText.text = "timer; "+ timer.ToString();
        if (timer == 0)
        {
            timesUpText.gameObject.SetActive(true);
            Invoke(nameof(GoToMenu),3);
            CancelInvoke(nameof(Countdown));
        }
    }

    private void GoToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
