using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRockByContact : MonoBehaviour
{
    private GameController gameController;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            gameController.GameOver();
        }

        if (other.tag == "Cornisa")
        {
            Destroy(gameObject);
        }

    }
}
