using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using TMPro;
using Random = UnityEngine.Random;



public class AnimalControllerTwo : MonoBehaviour
{

    public QuestionList[] questions;
    public TMP_Text text;
    private List<object> qList;
    public TMP_Text[] texts;
    private QuestionList crntQ;
    private int time = 5;
    private bool stopTime = true;
    public OnClickScore score;
    public TMP_Text Timer;
    [SerializeField] private Slider _hp;

    private OpenSelectedWindow selectedWindow;

    [SerializeField] private GameObject panel;

    public void Start()
    {
        qList = new List<object>(questions);
        QuestionGenerate();
    }

    public void anwsersBttns(int index)
    {
        stopTime = true;

        panel.SetActive(false);
        //здесь выключать
        if (texts[index].text.ToString() == crntQ.anwsers[0]) score.OnTrueClick();
        else
        {
            score.OnFalseClick();
            TakeDamage();

        }

        StartCoroutine(Wait());

    }

    void QuestionGenerate()
    {
        StartCoroutine(timer());
        crntQ = qList[Random.Range(0, qList.Count)] as QuestionList;
        text.text = crntQ.question;
        List<string> anwsers = new List<string>(crntQ.anwsers);
        for (int i = 0; i < crntQ.anwsers.Length; i++)
        {
            int rand = Random.Range(0, anwsers.Count);
            texts[i].text = anwsers[rand];
            anwsers.RemoveAt(rand);
        }
    }

    IEnumerator timer()
    {
        //здесь включать
        panel.SetActive(true);
        Timer.text = time.ToString();
        time = 6;
        stopTime = false;
        while (time > 0)
        {
            if (!stopTime)
            {
                time--;
                Timer.text = time.ToString();
                yield return new WaitForSeconds(1);
            }
            else yield break;
        }

    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(10);
        // сделать выплывающие кнопки
       
        QuestionGenerate();

    }

    private void TakeDamage()
    {
        _hp.value -= 1;
        if (_hp.value <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
[System.Serializable]
public class QuestionListTwo
{
    public string question;
    public string[] anwsers = new string[4];
}