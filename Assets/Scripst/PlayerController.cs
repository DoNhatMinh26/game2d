using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed =5f;
    [SerializeField] private float jumpForce =15f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private Animator animator;
    private bool isGrounded;
    private Rigidbody2D rb;
    private GameManager gameManager;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb= GetComponent<Rigidbody2D>();
        gameManager=FindAnyObjectByType<GameManager>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.IsgameOver() || gameManager.IsGameWin()) return;
        HandleMovement();
        HandleJump();
        updateAnimation();
    }
    private void HandleMovement(){
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        // xu ly lật nhan vat.
        if(moveInput>0) transform.localScale = new Vector3(1,1,1);
        else if(moveInput<0) transform.localScale = new Vector3(-1,1,1);  
    }
    private void HandleJump(){
        if(Input.GetButtonDown("Jump") && isGrounded){
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
        //khi chạm đất mới được nhảy.
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void updateAnimation(){
        bool isRunning = Mathf.Abs(rb.linearVelocity.x) > 0.1f;
        bool isJumping = !isGrounded;
        animator.SetBool("isRunning",isRunning);
        animator.SetBool("isJumping",isJumping);
    }
}
