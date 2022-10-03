using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    //[SerializeField] private Image _animal;
    [SerializeField] private GameObject _animalPrefab;
    [SerializeField] private GameObject _gameController;

    [SerializeField] private Transform _room;
    [SerializeField] protected GameObject _buttonBuy;

    private void Update()
    {
        
    }

    public void OnBuyAnimal()
    {
        Instantiate(_animalPrefab, _room.position, Quaternion.identity);       
        Instantiate(_gameController, _room.position, Quaternion.identity);       
        _buttonBuy.SetActive(false);
    }

    public void DeathAnimal()
    {
        _buttonBuy.SetActive(true);
    }
}
