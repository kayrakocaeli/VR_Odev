using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsPlaceHolder : MonoBehaviour
{
    public GameObject CorrectText;
    public GameObject FalseText;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Stairs"))
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
