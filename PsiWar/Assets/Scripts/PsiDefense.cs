using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsiDefense : MonoBehaviour {

    public float hitPoints;

    public void TakeDamage(float amount)
    {
        hitPoints -= amount;
        if (hitPoints <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
