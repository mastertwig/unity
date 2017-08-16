using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsiAttack : MonoBehaviour {

    private PsiDefense psiDefense;
    private float psiDamage;
    public float psiDamageMin;
    public float psiDamageMax;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                
                psiDefense = hit.collider.GetComponent<PsiDefense>();
                Attack();
            }
        }
    }

    void Attack()
    {
        psiDamage = Random.Range(psiDamageMin, psiDamageMax);
        psiDamage = Mathf.Round(psiDamage);
        Debug.Log(psiDamage + " damage to " + psiDefense.name);
        psiDefense.TakeDamage(psiDamage);
    }
}
