using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ammaridevelopment.superflappy
public class EnemyRotate : MonoBehaviour
{
    public Transform enemyT, oEnemyT;
    private bool Collisons = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collisons = Physics2D.Linecast(enemyT.position, oEnemyT.position, 1 <<LayerMask.NameToLayer("rotate")); 
        if(Collisons)
           transform.localScale = new Vector3(transform.localScale.x*-1, transform.localScale.y,transform.localScale.z);
    }
}
