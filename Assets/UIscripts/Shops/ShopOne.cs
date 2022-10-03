using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShopOne : MonoBehaviour
{
    [SerializeField] private Image _animal;
    [SerializeField] private Transform _room;
    [SerializeField] protected GameObject _buttonBuy;

    private void Update()
    {

    }

    public void OnBuyAnimal()
    {
        Instantiate(_animal, _room.position, Quaternion.identity);
        _buttonBuy.SetActive(false);
    }

    public void DeathAnimal()
    {
        _buttonBuy.SetActive(true);
    }
}
