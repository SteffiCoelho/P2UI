using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            bool isWalking = animator.GetBool("isWalking");
            animator.SetBool("isWalking", true);
            Debug.Log(animator.GetBool("isWalking"));
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            bool isWalking = animator.GetBool("isWalking");
            animator.SetBool("isWalking", false);
            Debug.Log(animator.GetBool("isWalking"));
        }
    }
}
