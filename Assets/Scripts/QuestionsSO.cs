using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Quiz Question", order = 0)]
public class QuestionsSO : ScriptableObject {

    // question box in inspector panel
    [TextArea(2,6)]
    [SerializeField] string question = "New question text goes here";

    public string GetQuestion() {
        return question;
    }
}
