using UnityEngine;

public class Finish : MonoBehaviour
{
    public GlobalEventsSystem globalEventsSystem;
    void Start()
    {
        globalEventsSystem = GameObject.FindGameObjectWithTag("GlobalEventSystem").GetComponent<GlobalEventsSystem>();
    }
    public void OnTriggerEnter(Collider other)
    {

        globalEventsSystem.Victory.Invoke();
        Destroy(other.gameObject);
    }
}
