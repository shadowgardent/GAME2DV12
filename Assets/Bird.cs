using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public float flapStrength = 5 ;
    public LogicScript logic ;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
          myRigibody.velocity = Vector2.up * flapStrength;
      }
    }

    private void OnCollisionEnter2D(Collision2D collision2D){
        
        logic.gameOver();
        birdIsAlive = false;
        
        
    }
}
