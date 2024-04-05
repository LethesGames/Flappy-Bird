using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject pipesPrefab;
    public GameObject bird;
    public TMP_Text playerScoreTMP;
    private BirdController birdController;
    private float timer = 2f;
    private int playerScore = 0;
    public GameObject gameOverEmpty;


    private void Awake() {
        birdController = bird.GetComponent<BirdController>();   
        playerScoreTMP.text = playerScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(birdController.GetIsAlive()){
            SpawnPipe();
        }            
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;  
        if(timer <= 0 && birdController.GetIsAlive()){
            SpawnPipe();
            timer = UnityEngine.Random.Range(2f, 4f);
            spawnPoint.transform.position = new Vector3(spawnPoint.transform.position.x, UnityEngine.Random.Range(-2.3f, 2.3f), spawnPoint.transform.position.z);
        } 

        if(!birdController.GetIsAlive() && Input.GetKeyDown("space")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void birdCollide(){
        Debug.Log("You died");
        birdController.SetIsAlive(false);
        gameOverEmpty.SetActive(true);
    }

    private void SpawnPipe() {
        Instantiate(pipesPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }

    public void IncrementPlayerScore() {
        playerScore ++;
        playerScoreTMP.text = playerScore.ToString();
    }

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
