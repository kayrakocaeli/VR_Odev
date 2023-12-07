using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismPlaceHolder : MonoBehaviour
{
    public GameObject CorrectText;
    public GameObject FalseText;
    public Transform PrismTransform;
    public Transform ConeTransform;
    public Transform SphereTransform;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Prism"))
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
    public void GotoTruePos()
    {
        if ((gameObject.CompareTag("Cone")))
        {
            gameObject.transform.position = ConeTransform.transform.position;
        }
        else if ((gameObject.CompareTag("Sphere")))
        {
            gameObject.transform.position = SphereTransform.transform.position;
        }
        else if ((gameObject.CompareTag("Prism")))
        {
            
        }
    }

}
