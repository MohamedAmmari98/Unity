using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ammaridevelopment.superflappy
public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D reg;
    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        reg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       reg.velocity = new Vector2 (transform.localScale.x,0) * speed;
    }
}
