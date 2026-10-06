using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    public MoveEnemy enemy;
    public HealthPlayer healthPlayer;
    public MovePlayer player;
    public AreaAttack areaAttack;
    private int damage = 1;

    public void AttackPlayer()
    {
        if (areaAttack.GetIsHitPlayer())
        {
            healthPlayer.ChangeHP(-damage);
            player.KnockBack(enemy.transform);
        }
    }

    public void StartAttack()
    {
        enemy.ChangeCanMove(false);
    }
    public void EndAttack()
    {
        enemy.ChangeCanMove(true);
    }
}
