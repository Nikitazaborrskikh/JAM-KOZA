using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;
using Random = UnityEngine.Random;

public class RanDomSwap : MonoBehaviour
{
    [SerializeField] private string[] _actions;
    [SerializeField] private TMP_Text _actionText;




    public string ChangeAction()
    {
        string curraction = _actions[Random.Range(0, _actions.Length)];
        _actionText.text = curraction;
        return _actionText.text;
    }

    private void Start()
    {
        ChangeAction();
    }

    public void CheckAction(int numberAction)
    {
        if (_actionText.text == _actions[0])
        {
            numberAction = 0;
        }
       if (_actionText.text == _actions[1])
        {
            numberAction = 1;
        }

        if (_actionText.text == _actions[2])
        {
            numberAction = 2;
        }
        if (_actionText.text == _actions[3])
        {
            numberAction = 3;
        }

        
    }
    
}
