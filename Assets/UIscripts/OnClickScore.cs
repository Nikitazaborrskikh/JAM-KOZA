using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class OnClickScore : MonoBehaviour
{
    
    private bool _correctButtonIsPressed = false;

    [SerializeField] private TMP_Text _scoreText;

    private int _scoreClick = 50;
    private int _score;
    private int _falseScore;
  
    

    private void Awake()
    {
        _scoreText.text = "0";
       
    }

    private void Update()
    {

        //Debug.Log(_score);
    }

    public void OnTrueClick()
    {
        _score += _scoreClick;
        _scoreText.text = _score.ToString();
    }

    public void OnFalseClick()
    {
        _score -= _scoreClick;
        _scoreText.text = _score.ToString();
    }
    
    public void Win()
    {
        if (_score >= 20_000)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void Buy()
    {
        _score -= 25;
        _scoreText.text = _score.ToString();
    }

    public void BuyOne()
    {
        _score -= 200;
        _scoreText.text = _score.ToString();
    }

    public void BuyTwoAndThree()
    {
        _score -= 1000;
        _scoreText.text = _score.ToString();
    }

    public void BuyFour()
    {
        _score -= 1500;
        _scoreText.text = _score.ToString();
    }
}
