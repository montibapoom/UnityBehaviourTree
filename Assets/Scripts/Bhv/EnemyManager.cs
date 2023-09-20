using Assets.Scripts.Bhv.NewRealisation.Interfaces;
using TMPro;
using UnityEngine;

public class EnemyManager : MonoBehaviour, IHit
{
    [SerializeField]
    private TMP_Text text;

    private int healthPoints;

    private void Awake()
    {
        healthPoints = 300;
        text.UpdateText($"Current health: {healthPoints}");
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    public void Hit(int damage)
    {
        healthPoints -= damage;

        if (healthPoints <= 0)
        {
            Die();
        }

        text.UpdateText($"Current health: {healthPoints}");
    }
}
