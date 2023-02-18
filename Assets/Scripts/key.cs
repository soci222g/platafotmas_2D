using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class key : MonoBehaviour
{

    public Collider2D cl;
    [SerializeField]
    private UnityEvent collisonEneter;
    [SerializeField]
    private UnityEvent collisonExit;
    void Start()
    {
       cl = GetComponent<Collider2D>();
    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (cl.transform.tag == "player")
        {
            collisonEneter?.Invoke();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (cl.transform.tag == "player")
        {
            collisonExit?.Invoke();
        }
    }

}
