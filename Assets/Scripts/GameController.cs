using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    private float time; // porque solo lo utilizamos aqui
    public Text timeText;

    public Text restartText;
    public Text gameOverText;
    public bool restart;
    public bool gameOver;

    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        UpdateText();
        restart = false;
        gameOver = false;
        gameOverText.gameObject.SetActive(false);
        restartText.gameObject.SetActive(false);
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame

    private void Update()
    {
        time += Time.deltaTime;
        UpdateText();
        if(restart && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0); // Carga la escena Main si el jugador ha muerto y pulsa R
        }
    }


    void UpdateText()
    {
        timeText.text = "Time: " + time;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
        gameOver = true;
        restart = true;
    }

    public void Win()
    {
        winText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
        restart = true;
    }
}
