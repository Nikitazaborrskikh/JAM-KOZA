using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActionFeed : IActionRandom
{
   public void Randomize(GameObject[] panel)
    {
        panel[Random.Range(0, panel.Length)].SetActive(true);
    }
}
