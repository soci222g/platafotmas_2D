using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static pauseMenu instance;
    public GameObject PauseMenu;
   public bool isPause
    {
        get;
        private set;
     }

private void Awacke()
{
        instance = this;
}
    // Start is called before the first frame update
    void Start()
    {
    isPause = false;
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isPause)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
            isPause = !isPause;
            PauseMenu.SetActive(isPause);
        }
    }

    public void Resumen()
    {
        Time.timeScale = 1;
        isPause = false;
        PauseMenu.SetActive(false);
    }
    public void MainMenu()
    {
        Debug.Log("ir a menu");
    }
}

