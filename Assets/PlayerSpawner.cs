using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerSpawner : MonoBehaviour
{

    public GameObject playerPrefab;
    GameObject playerInstance;

    public int numLives = 4;

    float respawnTimer;
    bool isGameOver = false;
    float gameOverTimer = 2f;

    // Use this for initialization
    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        numLives--;
        respawnTimer = 1;
        playerInstance = Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            if (playerInstance == null && numLives > 0)
            {
                respawnTimer -= Time.deltaTime;

                if (respawnTimer <= 0)
                {
                    SpawnPlayer();
                }
            }

            if (numLives <= 0 && playerInstance == null)
            {
                isGameOver = true;
            }
        }
        else
        {
            gameOverTimer -= Time.deltaTime;
            if (gameOverTimer <= 0)
            {
                SceneManager.LoadScene("EndGame");
            }
        }
    }

    void OnGUI()
    {
        if (numLives > 0 || playerInstance != null)
        {
            GUI.Label(new Rect(0, 0, 100, 50), "Lives Left: " + numLives);
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "Game Over, Man!");
        }
    }
}
