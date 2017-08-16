using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text hull;
    public Text noticeText;
    public GameObject player;
    private float hullPercentValue;
    private Health health;
    private float hullStart;
    private float hullCurrent;

    // Use this for initialization
    void Start()
    {
        health = player.GetComponent<Health>();
        hullStart = health.hull;
        noticeText.text = null;
    }

    // Update is called once per frame
    void Update()
    {
        hullCurrent = health.hull;
        hullPercentValue = (hullCurrent * 100) / hullStart;
        hull.text = "Health " + hullPercentValue + "%";
    }

}
