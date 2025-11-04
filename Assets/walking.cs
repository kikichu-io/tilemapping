using UnityEngine;

public class walking : MonoBehaviour
{
    Animator animator;
    public float speed = 1f;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Walk_Forward", true);
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Walk_Forward", false);

        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Walk_Back", true);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Walk_Back", false);

        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Walk_Left", true);
            transform.Translate(Vector3.left * speed * Time.deltaTime);


        }
        else
        {
            animator.SetBool("Walk_Left", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Walk_Right", true);
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
        else
        {
            animator.SetBool("Walk_Right", false);
        }
    }
}
