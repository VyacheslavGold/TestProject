using UnityEngine;
using UnityEngine.Events;

public class PlayerMove : MonoBehaviour
{
    //public GlobalEventsSystem globalEventsSystem;
    public Rigidbody PlayerRigidbody;
    public UnityEvent Jump;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    
    public float horizontal;
    public bool isGrounded;

    void Start()
    {
        transform.position =new Vector3 (0,5,0);
        //globalEventsSystem = GameObject.FindGameObjectWithTag("GlobalEventSystem").GetComponent<GlobalEventsSystem>();
        PlayerRigidbody =GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        

        if (isGrounded == true & Input.GetKey(KeyCode.Space))
        {
            Jump.Invoke();//прыжок
            PlayerRigidbody.AddForce(transform.up * jumpForce , ForceMode.Impulse);
            Debug.Log("Jump");
        }
        horizontal = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;

        

        PlayerRigidbody.linearVelocity = transform.TransformDirection(0,PlayerRigidbody.linearVelocity.y,horizontal);
        
    }
    public void OnCollisionStay(Collision other)
    {
        isGrounded = true;
       
    }
    public void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }
    
    
}
