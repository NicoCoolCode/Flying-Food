using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    [SerializeField] private int timer=60;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text timesUpText;
    [SerializeField] private TMP_Text scoreText;
    private int score;

    public void Score()
    {
        score++;
        scoreText.text = "score: " + score.ToString();
    }


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

    private void Awake()
    {
        instance = this;
    }
}
