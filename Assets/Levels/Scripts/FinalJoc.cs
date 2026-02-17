using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalJoc : MonoBehaviour
{
    [SerializeField] private GameObject MeniuFinalSucces;
    [SerializeField] private GameObject MeniuFinalPierdut;

    private void Awake()
    {
        MeniuFinalSucces.SetActive(false);
        MeniuFinalPierdut.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Time.timeScale = 0;
            int scor = QuizManager.instance.score;
            if (scor >= 80)
            {
                MeniuFinalSucces.SetActive(true);
                Debug.Log("Succes");

            }
            else
            {
                MeniuFinalPierdut.SetActive(true);
                Debug.Log("Pierdut");
            }
        }
    }
}
