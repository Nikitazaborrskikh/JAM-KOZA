using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSelectedWindow : MonoBehaviour
{
    public Transform box;
    public CanvasGroup Back;

    private void OnEnable()
    {
        Back.alpha = 0;
        Back.LeanAlpha(1, 0.5f);

        box.localPosition = Vector2.zero;
        box.LeanMoveLocalY(75, 0.5f).setEaseOutExpo().delay = 0.1f;
    }


    public void CloseShop()
    {
        Back.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.width, 0.5f).setEaseInExpo().setOnComplete(Complete);
    }

    void Complete()
    {
        gameObject.SetActive(false);
    }
}
