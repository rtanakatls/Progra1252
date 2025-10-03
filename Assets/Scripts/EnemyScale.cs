using UnityEngine;

public class EnemyScale : MonoBehaviour,IObserver
{
    private void Start()
    {
        GameManager.Instance.Attach(this);  
    }

    public void Execute(ISubject subject)
    {
        transform.localScale=Vector3.one*((GameManager)subject).Progression;
    }

    private void OnDestroy()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.Detach(this);
        }
    }

}
