using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin")){
            Destroy(collision.GameObject());
            gameManager.AddScore(1);
        }
        else if(collision.CompareTag("Trap")){
            gameManager.GameOver();
        }
        else if(collision.CompareTag("Enemy")){
            gameManager.GameOver();
        }
        else if(collision.CompareTag("Key")){
            gameManager.GameWin();
        }
    }
}
