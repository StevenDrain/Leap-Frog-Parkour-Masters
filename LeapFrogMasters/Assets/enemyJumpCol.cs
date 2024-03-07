using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyJumpCol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            
            Destroy(transform.parent.gameObject);
            Debug.Log("dead");
        }
        if(col.gameObject.tag == "Player2"){
            
            Destroy(transform.parent.gameObject);
            Debug.Log("dead");
        }
    }
}
