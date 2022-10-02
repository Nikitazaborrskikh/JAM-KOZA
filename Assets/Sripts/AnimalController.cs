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
    private bool _buttonIspressed = false;

    public void Start()
    {
        StartCoroutine(Idle());
    }

    IEnumerator WannaEat()
    {
        _text.SetActive(true);
        while (_buttonIspressed == false)
        {
            time.value -= 0.01f;
        }
        
        if (time.value == 0f)
        {
            hp.value -= 1f;
        }
        yield return new WaitUntil((() => _buttonIspressed == true || time.value == 0));
        StartCoroutine(Idle());
    }

    IEnumerator Idle()
    {
        _text.SetActive(false);
        _buttonIspressed = false;
        time.value = time.maxValue;
        yield return new WaitForSeconds(1f);
        StartCoroutine(WannaEat());
    }

    public void Feed()
    {
        _buttonIspressed = true;
        
        StartCoroutine(Idle());
    }
}
