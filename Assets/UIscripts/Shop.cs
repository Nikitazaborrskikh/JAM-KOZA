using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private Image _animal;
    [SerializeField] private Transform _room;


    public void OnBuyAnimal()
    {
        Instantiate(_animal, _room.position, Quaternion.identity);
    }
}
