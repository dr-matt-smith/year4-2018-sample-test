using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager{

    private int totalQuestionsAttempted;
    private int totalQuestionsCorrect;
    private int passPercentage;


    public QuizManager()
    {
        totalQuestionsAttempted = 0;
        totalQuestionsCorrect = 0;
        passPercentage = 50;
    }


    public int GetTotalQuestionsAttempted()
    {
        return totalQuestionsAttempted;
    }
    public int GetTotalQuestionsCorrect()
    {
        return totalQuestionsCorrect;
    }
    public int GetTotalQuestionsWrong()
    {
        return totalQuestionsAttempted - totalQuestionsCorrect;
    }

    public void AddOneToCorrectTotal()
    {
        totalQuestionsAttempted++;
        totalQuestionsCorrect++;
    }
    public void AddOneToWrongTotal()
    {
        totalQuestionsAttempted++;
    }

    public int GetPercentageQuestionsCorrect()
    {
        if (totalQuestionsAttempted == 0)
            return 0;
        return (totalQuestionsCorrect * 100) / totalQuestionsAttempted;
    }

    public int GetPassPercentage()
    {
        return passPercentage;
    }
    public void SetPassPercentage(int value)
    {
        if(0 < value && value <= 100)
            passPercentage = value;
    }
}
