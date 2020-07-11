using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizController : MonoBehaviour
{
    public Text question;
    public Text ansA;
    public Text ansB;
    public Text ansC;
    public Text ansD;
    public Text infoQuestion;

    public string[] questions;      // armazena todas as perguntas
    public string[] answersA;       // amazena todas as alternativas A
    public string[] answersB;       // amazena todas as alternativas B
    public string[] answersC;       // amazena todas as alternativas C
    public string[] answersD;       // amazena todas as alternativas D
    public string[] rightAnswers;   // armazena as alternativas corretas

    private int idQuestion;
    private float rights;
    private float numquestions;
    private float avg;


    // Start is called before the first frame update
    void Start()
    {
        idQuestion = 0;
        numquestions = questions.Length;

        question.text = questions[idQuestion];
        ansA.text = answersA[idQuestion];
        ansB.text = answersB[idQuestion];
        ansC.text = answersC[idQuestion];
        ansD.text = answersD[idQuestion];

        infoQuestion.text = "Respondendo " + (idQuestion + 1) + " de " + numquestions + " perguntas";
    }

    public void SetAnswer(string op)
    {
        if(op == "A")
        {

        }else if(op == "B")
        {

        }else if(op == "C") 
        {
            
        }else if(op == "D")
        {

        }
    }
}
