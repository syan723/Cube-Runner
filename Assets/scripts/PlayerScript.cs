using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    public Rigidbody rb;
    public float force = 1500f;
    public float speed = 10f;
    public float minX =-4.5f;
    public float maxX = 4.5f;
    public PlayerScript playerScript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    
    



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPos = transform.position;

        if( PlayerPos.x < minX )
        { 
            PlayerPos.x = minX; 
        }
        transform.position = PlayerPos;
        if( PlayerPos.x > maxX ) {  
            PlayerPos.x = maxX; 
        }
        transform.position = PlayerPos;
       /* if(Input.touchCount > 0 )
        {
            Debug.Log(Input.GetTouch(0).position);
        }*/
        PlayerPos.x = Mathf.Clamp(PlayerPos.x, minX, maxX);
        transform.position = PlayerPos;


        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position=transform.position+ new Vector3(speed * Time.deltaTime, 0,0);

        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed*Time.deltaTime, 0, 0);

        }
      
    }
    private void FixedUpdate()
    {
       transform.Translate(Vector3.forward*12 *Time.deltaTime);
      //rb.AddForce(0, 0, force* Time.deltaTime);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
           
            Destroy(gameObject);
            Debug.Log("Finished ");
            gameController.GameOver();
            
               
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Collactables") {

            score.AddScore(1);
            Destroy(other.gameObject);
            audioSource.Play();
        }
    }
}

