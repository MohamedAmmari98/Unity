using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ammaridevelopment.superflappy
public class CameraFollow : MonoBehaviour
{
     // The Target
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(target.position.x+1.7f,transform.position.y,transform.position.z);
        
    }
}
