using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ammaridevelopment.superflappy
public class coins : MonoBehaviour
{
    //AUDIO CLIP
       public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // WHEN PLAYER GET COIN.
     void OnTriggerEnter2D(Collider2D coin){
        if(coin.gameObject.tag == "Player"){
          // DESTROY COIN
          Destroy(gameObject);
          AudioSource.PlayClipAtPoint(audioClip, transform.position);

    }
    }
}
