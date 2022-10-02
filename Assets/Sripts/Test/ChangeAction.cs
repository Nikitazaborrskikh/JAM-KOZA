using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeAction : MonoBehaviour
{
    [SerializeField] private GameObject[] panel;
    private IActionRandom actionRandom;

    private void Start()
    {
       NewActions();
    }

    private void NewActions()
    {
        actionRandom = new ActionFeed();
        actionRandom.Randomize(panel);
    }

    public void OnClosePanel()
    {
        ChangeSkils(new ActionClose());
    }

    public void ChangeSkils(IActionRandom actionRandom)
    {
        this.actionRandom = actionRandom;
    }
}
