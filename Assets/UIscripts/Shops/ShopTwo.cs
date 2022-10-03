using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopTwo : MonoBehaviour
{
    //[SerializeField] private Image _animal;
    [SerializeField] private GameObject _animalPrefab;
    [SerializeField] private GameObject _gameController;

    //[SerializeField] private Transform _room;
    [SerializeField] protected GameObject _buttonBuy;

    //[SerializeField] private Vector3 _roomPosition;


    private void Update()
    {

    }



    public void OnBuyAnimal()
    {

        _animalPrefab.SetActive(true);
        _gameController.SetActive(true);
        //_openAll.OpenAll();
        _buttonBuy.SetActive(false);
    }

    public void DeathAnimal()
    {
        _buttonBuy.SetActive(true);
    }
}
