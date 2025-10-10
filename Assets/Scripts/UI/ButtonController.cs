using System;
using UnityEngine;
using UnityEngine.UI;


public class ButtonController : MonoBehaviour
{
    [SerializeField] private ImageController imageController;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            imageController.Execute(() =>
            {
                Destroy(gameObject);
            });
        });
    }
}
