using UnityEngine;

public class Health : MonoBehaviour {

    public float hull;
    public Transform explosion;

    public void TakeDamage (float amount)
    {
            hull -= amount;
            if (hull <= 0f)
            {
                hull = 0f;
                Die();
            }
    }

    private void Die()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
