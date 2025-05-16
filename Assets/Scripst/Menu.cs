using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("map");
    }
    public void M0()
    {
        SceneManager.LoadScene("0");
    }
    public void M1()
    {
        SceneManager.LoadScene("Game");
    }
    public void M2()
    {
        SceneManager.LoadScene("2");
    }
    public void M3()
    {
        SceneManager.LoadScene("3");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
