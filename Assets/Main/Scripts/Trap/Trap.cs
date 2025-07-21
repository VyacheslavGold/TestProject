using UnityEngine;

public class Trap : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerHealth>().health -= 1;
    }
}
