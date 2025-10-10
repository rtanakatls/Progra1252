using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    private Image image;

    private void Awake()
    {
        image=GetComponent<Image>();
    }

    public void Execute(Action OnCompleted)
    {
        StartCoroutine(ReduceContent(OnCompleted));
    }

    private IEnumerator ReduceContent(Action OnCompleted)
    {
        while (image.fillAmount>0)
        {
            image.fillAmount -= Time.deltaTime/5;
            yield return null;
        }
        OnCompleted?.Invoke();
    }
}
