using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    GameObject[] gameObjects;
    [SerializeField] Text scoreText;
    [SerializeField] int TotalScore;
    [SerializeField] GameObject darkScreen;
    [SerializeField] GameObject frame;

    [SerializeField] GameObject goblin;
    [SerializeField] bool IsPause;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnSprite());
        IsPause = false;
    }

    IEnumerator spawnSprite()
    {
        while (IsPause == false )
        {
            yield return new WaitForSeconds(1f);

            for (int i = 0; i < 10; i++)
            {
                float posY = Random.Range(Camera.main.ScreenToWorldPoint
               (new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint
               (new Vector2(0, Screen.height)).y);

                float posX = Random.Range(Camera.main.ScreenToWorldPoint
                   (new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint
                   (new Vector2(Screen.width, 0)).x);

                Vector2 spawnPos = new Vector2(posX, posY);

                Instantiate(goblin, spawnPos, Quaternion.identity);
            }
        }
    }

    private void Update()
    {
        TotalScore = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Score: " + TotalScore.ToString();
        /*if(IsPause == false) 
        {
            gameObjects = GameObject.FindGameObjectsWithTag("goblin");
            foreach (GameObject goblin in gameObjects) 
            {
                GameObject.Destroy(goblin);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                PauseGame();
            }
        }*/
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseGame();
        }
    }

    public void PauseGame() 
    {
        IsPause = true;
        darkScreen.SetActive(true);
        frame.SetActive(true);
    }
    public void ResumeGame() 
    {
        IsPause = false;
        darkScreen.SetActive(false);
        frame.SetActive(false);
        StartCoroutine(spawnSprite());
    }

    public void MenuScene() 
    {
        SceneManager.LoadScene("MainMenu");
    }

}
