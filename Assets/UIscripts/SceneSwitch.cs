using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private int _nextScene;

   public void NextScene()
    {
        SceneManager.LoadScene(_nextScene);
    }
}
