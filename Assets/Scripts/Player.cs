using UnityEngine;
public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement
    private Animator animator;   // Reference to Animator component
    bool isWalking = false; // Start as false
    public AudioClip jumpSound; // Assign your jump sound in the Inspector
    private AudioSource audioSource; //reference to Audio Source component
    private Rigidbody2D rb;

    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator on the player
        audioSource = GetComponent<AudioSource>(); //Get the Audio Source on the Player
        rb = GetComponent<Rigidbody2D>(); //Get the Rigidbody of Player
    }

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;
        isWalking = false; // make sure iswalking is consistently false unless we press left or right or a or d

        bool isGrounded = Mathf.Abs(rb.linearVelocity.y) < 0.01f; // Close to zero = on the ground 

        // Check for WASD and Arrow Key inputs
        if (Input.GetKeyDown(KeyCode.W) && isGrounded || Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection.y -= 1;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection.x -= 1;
            isWalking = true; //set the iswalking bool to true
            transform.localScale = new Vector3(-1, transform.localScale.y); // Flip the sprite left
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection.x += 1;
            isWalking = true;  //set the iswalking bool to true
            transform.localScale = new Vector3(1, transform.localScale.y); // Flip the sprite right
        }

        // Move the player
        transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;

        // Set animation bool to true or false, depending on if the player is pressing left, right, a or d OR not pressing anything
        animator.SetBool("Walk", isWalking);
    }

    public void Jump()
    {
        if (jumpSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(jumpSound);
        }

        rb.AddForce(transform.up * 5, ForceMode2D.Impulse);


    }
}
