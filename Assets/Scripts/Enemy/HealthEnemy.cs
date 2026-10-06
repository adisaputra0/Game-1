using UnityEngine;
using TMPro;

public class HealthEnemy : MonoBehaviour
{
    private int hp = 3;
    private int maxHP = 3;
    public MoveEnemy enemy;
    public TMP_Text textHP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textHP.text = hp+"/"+maxHP;
    }
    void Update()
    {
        textHP.text = hp + "/" + maxHP;
        if (hp <= 0)
        {
            enemy.Die();
        }
    }

    public void ChangeHP(int value)
    {
        hp += value;
    }
}
