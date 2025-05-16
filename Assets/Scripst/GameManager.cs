using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameWinUI;
    private bool isGameOver=false;
    private bool isGameWin = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
    }

    // Update is called once per frame
    public void AddScore(int points){
        if(!isGameOver && !isGameWin){
            score+= points;
            UpdateScore();
        }
    }
    private void UpdateScore(){
        scoreText.text = score.ToString();
    }
    public void GameOver(){
        isGameOver=true;
        score=0;
        Time.timeScale=0;
        gameOverUI.SetActive(true);
    }
    public void GameWin(){
        isGameWin=true;
        Time.timeScale = 0;
        gameWinUI.SetActive(true);
    }
    public void RestarGame0()
    {
        isGameOver = false;
        score = 0;
        UpdateScore();
        Time.timeScale = 1;
        SceneManager.LoadScene("0");

    }
    public void RestarGame1(){
        isGameOver=false;
        score=0;
        UpdateScore();
        Time.timeScale=1;
        SceneManager.LoadScene("Game");

    }
    public void RestarGame2()
    {
        isGameOver = false;
        score = 0;
        UpdateScore();
        Time.timeScale = 1;
        SceneManager.LoadScene("2");

    }
    public void RestarGame3()
    {
        isGameOver = false;
        score = 0;
        UpdateScore();
        Time.timeScale = 1;
        SceneManager.LoadScene("3");

    }
    public void GotoMenu(){
        Time.timeScale=1;
        SceneManager.LoadScene("map");
    }
    public bool IsgameOver(){
        return isGameOver;
    }
    public bool IsGameWin(){
        return isGameWin;
    }
}
