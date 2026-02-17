using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public Text QuestionText;
    public Text ScoreText;
    public int score = 0;
    public static QuizManager instance;

    private void Start()
    {
        ScoreText.text = "SCOR: 0";
        generateQuestion();
    }

    private void Awake()
    {
        instance = this;
    }

    public void correct()
    {
        score = score + 10;
        ScoreText.text = "SCOR:" + score;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void setAnwers()
    {
        for(int i=0; i<options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            if (QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent <AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionText.text = QnA[currentQuestion].Question;
            setAnwers();
        }
        else Debug.Log("Out of Questions");
    }
}
