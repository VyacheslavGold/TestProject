using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GlobalEventsSystem globalEventsSystem;

    public int health = 2;
    void Start()
    {
        globalEventsSystem = GameObject.FindGameObjectWithTag("GlobalEventSystem").GetComponent<GlobalEventsSystem>();
    }
     
     void FixedUpdate()
     {
        if(health <= 0)
        {
            Die();
        }
     }
     void Die()
     {
        globalEventsSystem.GameOver.Invoke();
     }
}
