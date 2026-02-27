//GameManager
//Score variable
//Function for adding to score
//Update the text to display the score
//Function for GameOver (should turn on Game Over text and restart button)
//Restart function that resets the scene
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager manager;//call to other functions

    public TextMeshProUGUI scoreText;//score text
    [SerializeField] public GameObject GameOverPanel;//game over pannel

    int score = 0;//variable to hold the player score 0 at start

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartGame();//call startgame
        UpdateScoreText();//call updatescoretext
    }


    public void StartGame()
    {
        GameOverPanel.SetActive(false);//Hide game over
        Time.timeScale = 1f;// start game movement
        score = 0;//initial score 0 
    }


    private void Awake()
    {
        manager = this;//for other scripts to access 
    }


    public void AddScore (int amount)
    {
        score += amount;//add set amount (10) from enemy to score
        UpdateScoreText ();//update score
    }

    
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();//updates score text to show current score
    }

    public void Restart()
    {
        Time.timeScale = 1f;// start game movement
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//reloads scene
    }

    public void GameOver()
    { 
        GameOverPanel.SetActive(true);//show game over pannel 
        Time.timeScale = 0f;//stop game
    }
}
