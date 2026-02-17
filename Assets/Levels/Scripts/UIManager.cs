using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject Quiz;
    [SerializeField] private GameObject Intro;
    [SerializeField] private GameObject MeniuFinalSucces;
    [SerializeField] private GameObject MeniuFinalPierdut;
    [SerializeField] private GameObject MeniuVolum;

    public void Quit()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        //inchide aplicatia din editor
        #endif
    }

    private void Awake()
    {
        Time.timeScale = 0;
        Intro.SetActive(true);
        pauseScreen.SetActive(false);
        Quiz.SetActive(false);
        MeniuFinalSucces.SetActive(false);
        MeniuFinalPierdut.SetActive(false);
        MeniuVolum.SetActive(false);
    }
    
    public void InchideIntro()
    {
        Time.timeScale = 1;
        Intro.SetActive(false);
    }

    public void DeschideVolum()
    {
        MeniuVolum.SetActive(true);
        pauseScreen.SetActive(false);

    }

    public void BackVolum()
    {
        MeniuVolum.SetActive(false);
        pauseScreen.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseScreen.activeInHierarchy)//daca e activ deja meniul de pauza
                PauseGame(false);
            else
                PauseGame(true);
        }
    }

    public void PauseGame(bool status)
    {
        pauseScreen.SetActive(status);
        if(status)
            Time.timeScale = 0;
        else 
            Time.timeScale = 1;
    }
}

