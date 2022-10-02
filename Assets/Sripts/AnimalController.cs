using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class AnimalController : MonoBehaviour
{
    [SerializeField] private Slider hp;
    [SerializeField] private Slider timer;
    [SerializeField] private GameObject _text;
    [SerializeField] private GameObject  _button;
    private bool _buttonIspressed = false;
    private float _timeOut;
    private int _timeLeft = 100;

    
    

    public void Start()
    {
        StartCoroutine(Idle());
    }


    
    IEnumerator WannaEat()
    {
        _text.SetActive(true);
        _button.SetActive(true);
        yield return new WaitForSeconds(5f);
        
        if (_buttonIspressed == true)
        {
            StartCoroutine(Idle());
            
        }
        else
        {
            StartCoroutine(TakeDamage());
            StartCoroutine(Idle());
        }

        yield return null;

    }

    IEnumerator Idle()
    {
        _text.SetActive(false);
        _button.SetActive(false);
        _buttonIspressed = false;
        timer.value = timer.maxValue;
        
        yield return new WaitForSeconds(1f);
        StartCoroutine(WannaEat());
    }

    IEnumerator TakeDamage()
    {
        hp.value -= 1;
        yield return null;
    }

    
    public void Feed()
    {
        _buttonIspressed = true;
        
        StartCoroutine(Idle());
    }

    private void FixedUpdate()
    {
        timer.value = _timeLeft;
        _timeOut += 1 * Time.deltaTime;
        if (_timeOut >= 1)
        {
            _timeLeft -= 1;
            _timeOut = 0;
        }
        return;
    }
}
