using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class AnimalController : MonoBehaviour
{
    [SerializeField] private Slider hp;
    [SerializeField] private Slider time;
    [SerializeField] private GameObject _text;
    [SerializeField] private GameObject  _button;
    private bool _buttonIspressed = false;
    private bool timedOut = false;
    

    public void Start()
    {
        StartCoroutine(Idle());
    }

    IEnumerator WannaEat()
    {
        _text.SetActive(true);
        _button.SetActive(true);

        while(true)
        {
            
            if (time.value == 0)
            { 
                hp.value -= 1f;
                continue;
            }

            time.value--;



        }
        
        
        yield return new WaitUntil((() => _buttonIspressed == true || time.value == 0));
        StartCoroutine(Idle());
    }

    IEnumerator Idle()
    {
        _text.SetActive(false);
        _button.SetActive(false);
        _buttonIspressed = false;
        time.value = time.maxValue;
        yield return new WaitForSeconds(1f);
        StartCoroutine(WannaEat());
    }

    private IEnumerator TimeoutChecker(float timeout)
    {
        timedOut = false;
        while (timeout > 0)
        {
            timeout -= 0.01f;
            if (timeout <= 0)
            {
                timedOut = true;
                StopCoroutine(TimeoutChecker(time.value));
                
                yield return null;
                
                
            }
        }

        
        
        
    }
    public void Feed()
    {
        _buttonIspressed = true;
        
        StartCoroutine(Idle());
    }

    private void Update()
    {
        Debug.Log(time.value);
    }
}
