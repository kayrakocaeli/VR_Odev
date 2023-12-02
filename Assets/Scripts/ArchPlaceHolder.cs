using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArchPlaceHolder : MonoBehaviour
{
    public GameObject CorrectText;
    public GameObject FalseText;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Arch"))
        {
            CorrectText.gameObject.SetActive(true);
            FalseText.gameObject.SetActive(false);
        }
        else
        {

            CorrectText.gameObject.SetActive(false);
            FalseText.gameObject.SetActive(true);

        }
        
    }
    private void OnTriggerExit(Collider other) 
    {
        CorrectText.gameObject.SetActive(false);
        FalseText.gameObject.SetActive(false);
    }
}
