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

    private int _scoreClickTrue = 400;
    private int _scoreClickFAlse = 200;
    private int _score;
    private int _falseScore;

    

    private void Awake()
    {
        _scoreText.text = "0";
       
    }

    private void Update()
    {
        Win();
    }

    public void OnTrueClick()
    {
        _score += _scoreClickTrue;
        _scoreText.text = _score.ToString();
    }

    public void OnFalseClick()
    {
        _score -= _scoreClickFAlse;
        _scoreText.text = _score.ToString();
    }
    
    public void Win()
    {
        if (_score >= 20000)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void Buy()
    {
        if (_score > 400)
        {
            _score -= 400;
            _scoreText.text = _score.ToString();            
        }      
    }

    public void BuyTwo()
    {
        if (_score > 1200)
        {
            _score -= 1200;
            _scoreText.text = _score.ToString();
        }
    }

    public void BuyThree()
    {
        if (_score > 2000)
        {
            _score -= 2000;
            _scoreText.text = _score.ToString();
        }
    }

    public void BuyFour()
    {
        if (_score > 2800)
        {
            _score -= 2800;
            _scoreText.text = _score.ToString();
        }
    }

    public void BuyFive()
    {
        if (_score > 3500)
        {
            _score -= 3500;
            _scoreText.text = _score.ToString();
        }
    }
}
