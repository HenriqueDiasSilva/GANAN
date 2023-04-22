using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour
{
    public void Construtor(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void Sair()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
