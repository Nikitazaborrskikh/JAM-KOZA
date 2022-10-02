using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OnClickScore : MonoBehaviour
{
    [SerializeField] private Button _trueButton;
    [SerializeField] private Button _FalseButton1;
    [SerializeField] private Button _FalseButton2;
    [SerializeField] private Button _FalseButton3;

    [SerializeField] private TMP_Text _scoreText;

    private int _score;
    private int _falseScore;

    private void Awake()
    {
        _scoreText.text = "0";
    }   

    public void OnTrueClick()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }

    public void OnFalseClick()
    {
        --_score;
        _scoreText.text = _score.ToString();
    }
}
