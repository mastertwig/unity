using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsController : MonoBehaviour
{

    [SerializeField]
    private float fireRate;
    private float nextFire;
    private float myTime;
    public GameObject weapon;
    public GameObject gunLeft;
    public GameObject gunRight;
    private GameObject newPrefabLeft;
    private GameObject newPrefabRight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myTime = myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            nextFire = myTime + fireRate;
            newPrefabLeft = Instantiate(weapon, gunLeft.transform.position, gunLeft.transform.rotation);
            newPrefabRight = Instantiate(weapon, gunRight.transform.position, gunRight.transform.rotation);
            newPrefabLeft.name = this.gameObject.name + " laserLeft";
            newPrefabRight.name = this.gameObject.name + " laserRight";
            nextFire = nextFire - myTime;
            myTime = 0f;
        }
    }
}