using UnityEngine;

public class EnemyMovement : MonoBehaviour, IObserver
{
    private Rigidbody rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        GameManager.Instance.Attach(this);
    }

    public void Execute(ISubject subject)
    {
        speed = ((GameManager)subject).Progression;
    }

    private void Update()
    {
        rb.linearVelocity=Vector3.forward * speed;
    }

    private void OnDestroy()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.Detach(this);
        }
    }
}
