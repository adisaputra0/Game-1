using UnityEngine;

public class AreaChase : MonoBehaviour
{
    public MoveEnemy enemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemy.ChangeIsChasing(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemy.ChangeIsChasing(false);
        }
    }
}
