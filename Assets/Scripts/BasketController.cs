using UnityEngine;

public class BasketController : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            gameManager.CollectGoodApple();
            //Destroy(other.gameObject);
        }
        else if (other.CompareTag("RottenApple"))
        {
            gameManager.CollectRottenApple();
            //Destroy(other.gameObject);
        }
    }
}
