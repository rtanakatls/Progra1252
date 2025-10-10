using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManagerV2.Instance.OnProgressionChanged += Execute;
    }

    public void Execute(int progression)
    {
        speed = progression;
    }

    private void Update()
    {
        rb.linearVelocity = Vector3.forward * speed;
    }

    private void OnDestroy()
    {
        if (GameManagerV2.Instance != null)
        {
            GameManagerV2.Instance.OnProgressionChanged -= Execute;
        }
    }
}
