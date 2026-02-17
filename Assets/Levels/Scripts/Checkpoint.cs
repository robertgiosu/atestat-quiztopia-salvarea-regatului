using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] GameObject Quiz;
    private float timeRemaining = 20f; // 20 seconds
    private bool isQuestionVisible = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Generate question");
            Quiz.SetActive(true);
            isQuestionVisible = true;
            timeRemaining = 20f;
        }
    }

    void Update()
    {
        if (isQuestionVisible)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Timer expired!");
                GetComponent<BoxCollider2D>().enabled = false;
                Quiz.SetActive(false);
                isQuestionVisible = false;
            }
        }
    }

}
