using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject rock;
    public int rockCount;
    public float spawnWait;
    public float startWait;
    public float timeBetweenWaves;
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRock());
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    // Update is called once per frame
    IEnumerator SpawnRock()
    {
        yield return new WaitForSeconds(startWait);
        while (true) // Para que siempre se repita este bucle hasta que sea GameOver
        {
            for (int i = 0; i < rockCount; i++)
            {
                Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                Instantiate(rock, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(timeBetweenWaves);

            
            if (gameController.gameOver == true)
            {
                break;
            }
            
        }


    }
}
