using System;
using UnityEngine;

public class GameManagerV2 : MonoBehaviour
{
    private static GameManagerV2 instance;

    public static GameManagerV2 Instance { get { return instance; } }

    public event Action<int> OnProgressionChanged;

    private int progression;
    private float timer;

    private void Awake()
    {
        instance = this;
    }


    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= progression)
        {
            progression++;
            OnProgressionChanged?.Invoke(progression);
        }
    }
}
