using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Animator anim;
    private bool isMoving;
    private bool isFacingRight = true;

    private bool canMove = true;
    private bool isKnockBack = false;
    private float knockBackForce = 10f;
    private float timeKnockBack = 0.3f;

    private bool isAttack = false;

    private float xInput;
    private float yInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMove();
        HandleFlip();
        HandleAnim();
    }

    private void HandleMove()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !isAttack)
        {
            isAttack = true;
            canMove = false;
            
            anim.SetTrigger("isAttacking");
        }

        if (canMove)
        {
            xInput = Input.GetAxisRaw("Horizontal");
            yInput = Input.GetAxisRaw("Vertical");
        }
        else
        {
            xInput = 0;
            yInput = 0;
        }
    }

    private void HandleAnim()
    {
        isMoving = xInput != 0 || yInput != 0;
        anim.SetBool("isMoving", isMoving);
    }

    public void ChangeIsAttack(bool value)
    {
        isAttack = value;
        canMove= !value;
    }

    private void HandleFlip()
    {
        if (xInput < 0 && isFacingRight)
        {
            Flip();
        }
        else if (xInput > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    public void KnockBack(Transform enemy)
    {
        isKnockBack=true;
        canMove = false;

        Vector2 direction = (transform.position - enemy.position).normalized;
        rb.linearVelocity = direction * knockBackForce;

        Invoke(nameof(ResetKnockBack), timeKnockBack);
    }

    private void ResetKnockBack()
    {
        isKnockBack = false;
        canMove = true;
    }

    private void FixedUpdate()
    {
        if (isKnockBack) return;
        rb.linearVelocity = new Vector2(xInput, yInput) * moveSpeed;
    }
}
