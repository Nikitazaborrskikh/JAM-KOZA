using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OnClickScore : MonoBehaviour
{
    
    private bool _correctButtonIsPressed = false;

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
