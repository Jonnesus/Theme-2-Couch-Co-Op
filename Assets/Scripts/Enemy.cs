using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    [SerializeField] ScoreCounter scoreCounter;
    
    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die ()
    {
        scoreCounter.score += 100;
        Destroy(gameObject);
    }
}