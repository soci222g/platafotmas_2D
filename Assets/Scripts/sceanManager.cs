using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceanManager : MonoBehaviour
{

    public void CanviarEscena(string name)
    {
        SceneManager.LoadScene(name);
    }
}
