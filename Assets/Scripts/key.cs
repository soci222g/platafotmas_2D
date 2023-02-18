using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class key : MonoBehaviour
{


    [SerializeField]
    private UnityEvent collisonEneter;


        private void OnTriggerEnter2D(Collider2D collision)
    {
  
        if (collision.gameObject.tag == "player")
        {
            collisonEneter?.Invoke();
        }
    }


}
