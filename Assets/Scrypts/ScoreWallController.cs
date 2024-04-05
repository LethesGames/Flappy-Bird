using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreWallController : MonoBehaviour
{

    private GameManager gameManagerScrypt;

    private void Awake()
    {
        gameManagerScrypt = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        gameManagerScrypt.IncrementPlayerScore();
    }
}
