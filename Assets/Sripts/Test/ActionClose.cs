using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionClose : IActionRandom
{
    public void Randomize(GameObject[] panel)
    {
        panel[Random.Range(0, panel.Length)].SetActive(false);
    }
}
