using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
    private void Start()
    {
        highScoreText.text = "highScore: " + PlayerPrefs.GetInt("highscore");
    }
}
