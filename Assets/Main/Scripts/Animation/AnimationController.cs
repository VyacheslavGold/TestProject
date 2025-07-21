using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] PlayerMove playerMove;
    public float timer;

    void Start()
    {   
        animator = GameObject.FindGameObjectWithTag("Animator").GetComponent<Animator>();
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        playerMove.Jump.AddListener(Jumping);
        
    }
    void FixedUpdate()
    {
        animator.SetBool("Grounded" , playerMove.isGrounded);
        animator.SetBool("FreeFall" , !playerMove.isGrounded);
        animator.SetBool("Running" , playerMove.horizontal != 0);

    }
    public void Jumping()
    {
        animator.SetBool("Jump" , true);
        Invoke("ResetJump" , 1.5f);
        Debug.Log("JumpAnim");
        
    }
    void ResetJump()
    {
        animator.SetBool("Jump", false);
        Debug.Log("resetJump");
    }
}
