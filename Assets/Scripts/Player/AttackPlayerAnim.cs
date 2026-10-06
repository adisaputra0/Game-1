using UnityEngine;

public class AttackPlayerAnim : MonoBehaviour
{
    public MovePlayer player;
    public AreaAttackPlayer areaAttack;
    public MoveEnemy enemy;
    public HealthEnemy healthEnemy;
    private int damage = 1;

    public void StartAttack()
    {
        if (areaAttack.GetIsHitEnemy())
        {
            enemy.KnockBack(player.transform);
            healthEnemy.ChangeHP(-damage);
        }
    }
    public void EndAnimation()
    {
        player.ChangeIsAttack(false);
    }
}
