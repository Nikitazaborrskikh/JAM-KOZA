using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class RandomAction : MonoBehaviour
{
    public string[] actions;
    [SerializeField] private TMP_Text text;
    private float timer;
    private float maintime = 10f;

    private void Start()
    {
        timer = maintime;
    }

    private void Update()
    {
        text.text = actions[Random.Range(0, actions.Length)];
        Debug.Log(text.text);
        timer = maintime;
    }
}
