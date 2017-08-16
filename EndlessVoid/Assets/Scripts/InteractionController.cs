using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour {

    private Interactable interact;
    public Text noticeText;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered " + other.gameObject.name);
        interact = other.GetComponent<Interactable>();
        if (interact != null)
        {
            Debug.Log(other.gameObject.name + "has Interactable script");
            noticeText.text = other.gameObject.name;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //clear current settings
        Debug.Log("Left " + other.gameObject.name);
        noticeText.text = null;
    }
}
