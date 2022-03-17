using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

// ammaridevelopment.superflappy
public class PlayerMove : MonoBehaviour
{
     // MOVEMENT SPEED
     public float speed = 2; 
     // FLAP FORCE
     public float force = 300;

     // WINNING PANEL
     public GameObject winningPanel;
     public GameObject menuButton;

     public GameObject solidObject1;
     public GameObject solidObject2;



    // Start is called before the first frame update
    void Start()
    {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
         // Flap
        if (Input.GetMouseButtonDown (0))
         GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);



    }

    // PLAYER DIE.
    void OnCollisionEnter2D(Collision2D solid) {
        if(solid.gameObject.tag == "solid"){
        // RESTART
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        // PLAYER GET ENDBANNER.
        else if(solid.gameObject.tag == "endBanner"){
            winningPanel.SetActive(true);
            Time.timeScale = 0;
            Destroy(solidObject1);
            Destroy(solidObject2);
            force = 0;
            menuButton.SetActive(false);
        }
    }
}
