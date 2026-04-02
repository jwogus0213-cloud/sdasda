using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public float attackInterval = 1f;

    public float attackTimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackTimer += Time.deltaTime;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) return;

        if (attackTimer < attackInterval) return;

        PlayerHealth1 playerHealth =other.GetComponent<PlayerHealth1>();

        if(playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            attackTimer = 0f;
        }
    }
}
