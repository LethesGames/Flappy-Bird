using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D birdRB;
    bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        birdRB = gameObject.GetComponent<Rigidbody2D>();
        birdRB.velocity = new Vector2(0, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isAlive){
            birdRB.velocity = new Vector2(0, 5f);
        }
    }

    public void SetIsAlive(bool isAlive) {
        this.isAlive = isAlive;
    }

    public bool GetIsAlive(){
        return isAlive;
    }
}
