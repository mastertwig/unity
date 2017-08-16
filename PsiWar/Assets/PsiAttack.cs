﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsiAttack : MonoBehaviour {

    private PsiDefense psiDefense;

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
                Debug.Log(hit.collider.name);
                psiDefense = hit.collider.GetComponent<PsiDefense>();
                Attack();
            }
        }
    }

    void Attack()
    {

    }
}
