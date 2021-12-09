using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Quiz Question", order = 0)]
public class QuestionsSO : ScriptableObject {

    // question box in inspector panel
    [TextArea(2,6)]
    [SerializeField] string question = "New question text goes here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion() {
        return question;
    }

    public string GetAnswer (int index) {
        return answers[index];
    }

    public int GetCorrectAnswerIndex() {
        return correctAnswerIndex;
    }
}
