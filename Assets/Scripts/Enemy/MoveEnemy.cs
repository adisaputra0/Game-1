using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float moveSpeed = 3f;
    public MovePlayer player;
    private Rigidbody2D rb;
    private Vector2 direction;
    private bool isMoving;
    private Animator anim;
    private bool isFacingRight = true;
    private bool isChasing = false;
    private bool canMove = true;
    private bool isAttack = false;

    private bool isKnockBack = false;
    private float knockBackForce = 10f;
    private float timeKnockBack = 0.3f;

    public UIEnemy uiEnemy;

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

    void HandleMove()
    {
        if (player != null && isChasing && canMove)
        {
            direction = (player.transform.position - transform.position).normalized;
        }else if (!isChasing || !canMove)
        {
            direction = Vector2.zero;
        }

    }

    void HandleAnim()
    {
        if (isAttack)
        {
            anim.SetTrigger("isAttacking");
            direction = Vector2.zero;
        }
        else
        {
            anim.ResetTrigger("isAttacking");
        }

        isMoving = direction != Vector2.zero;
        anim.SetBool("isMoving", isMoving);
    }

    public void ChangeIsAttack(bool value)
    {
        isAttack = value;
    }

    public void ChangeCanMove(bool value)
    {
        canMove = value;
    }

    void HandleFlip()
    {
        if(rb.linearVelocity.x < 0 && isFacingRight)
        {
            Flip();
        }else if (rb.linearVelocity.x > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        transform.Rotate(0,180,0);
        uiEnemy.Flip();
        isFacingRight = !isFacingRight;
    }

    public void ChangeIsChasing(bool value)
    {
        isChasing = value;
    }

    public void KnockBack(Transform player)
    {
        isKnockBack = true;
        canMove = false;

        Vector2 direction = transform.position - player.position;
        rb.linearVelocity = direction * knockBackForce;

        Invoke(nameof(ResetKnockBack), timeKnockBack);
    }

    public void ResetKnockBack()
    {
        isKnockBack= false;
        canMove=true;
    }

    void FixedUpdate()
    {
        if (isKnockBack) return;
        rb.linearVelocity = direction * moveSpeed;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
