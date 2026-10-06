using UnityEngine;

public class AreaAttackPlayer : MonoBehaviour
{
    private bool isHitEnemy = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            isHitEnemy = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            isHitEnemy= false;
        }
    }

    public bool GetIsHitEnemy()
    {
        return isHitEnemy;
    }
}
