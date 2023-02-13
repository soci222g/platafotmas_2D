using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{

    public bool key_piked;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    if (collision.gameObject.tag == "key"){
            
             key_piked = true;
        }
    
        
        

}
