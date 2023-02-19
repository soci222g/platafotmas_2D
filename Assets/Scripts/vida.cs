using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class vida : MonoBehaviour
{

    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive == false)
        {
            SceneManager.LoadScene("Game_over");
            Destroy(gameObject);
        }
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "spikes")
        {
            isAlive = false;


        }

    }
}
