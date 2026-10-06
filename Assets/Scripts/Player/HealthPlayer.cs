using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public int maxHP = 10;
    public int hp = 10;
    public int minHP = 0;
    public TMP_Text textHP;

    public ChangeScene gameScene;

    private void Start()
    {
        textHP.text = "HP: " + hp + "/" + maxHP;
    }

    private void Update()
    {
        textHP.text = "HP: " + hp + "/" + maxHP;
        if (hp <= 0)
        {
            gameScene.MoveToScene(4);
        }
    }

    public void ChangeHP(int value)
    {
        hp += value;
    }
}
