using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using TMPro;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;



public class AnimalController : MonoBehaviour
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

    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject _animalPrefab;
    [SerializeField] private GameObject _gameController;
    [SerializeField] private AudioSource _goodSound;
    [SerializeField] private AudioSource _badSound;
    [SerializeField] private AudioSource _piscSound;
    private Shop shop;


    public void Start()
    {
        qList = new List<object>(questions);
        shop = GetComponent<Shop>();
        QuestionGenerate();
    }

    public void anwsersBttns(int index)
    {
        stopTime = true;
        //здесь выключать
        panel.SetActive(false);


        if (texts[index].text.ToString() == crntQ.anwsers[0])
        {
            _goodSound.Play();
            score.OnTrueClick(); 
        }
        else
        {
            _badSound.Play();
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
        _piscSound.Play();
        panel.SetActive(true);
        Timer.text = time.ToString();
        time = 11;
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

        if (time <= 0)
        {
            panel.SetActive(false);
            TakeDamage();
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(10);
        // сделать выплывающие кнопки
        QuestionGenerate();

    }

    public void TakeDamage()
    {
        _hp.value -= 1;
        if (_hp.value <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        SceneManager.LoadScene(4);
        //shop.DeathAnimal();
        //_animalPrefab.SetActive(false);
        //this.gameObject.SetActive(false);
        //Destroy(_animalPrefab);
        //Destroy(_gameController);
    }
}
[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] anwsers = new string[6];
}