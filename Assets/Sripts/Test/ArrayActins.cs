using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ArrayActins : MonoBehaviour
{
    [SerializeField] private GameObject[] _arrayActions;   

    private void FixedUpdate()
    {
        GetPanel();
    }

    public void GetPanel()
    {        
        _arrayActions[Random.Range(0, _arrayActions.Length)].SetActive(true);        
    }
}
