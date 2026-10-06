using UnityEngine;

public class AreaAttack : MonoBehaviour
{
    public MoveEnemy enemy;
    private bool isHitPlayer = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemy.ChangeIsAttack(true);
            isHitPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemy.ChangeIsAttack(false);
            isHitPlayer = false;
        }
    }

    public bool GetIsHitPlayer()
    {
        return isHitPlayer;
    }
}
