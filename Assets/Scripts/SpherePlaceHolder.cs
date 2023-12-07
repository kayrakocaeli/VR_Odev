using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePlaceHolder : MonoBehaviour
{
    public GameObject CorrectText;
    public GameObject FalseText;
    public Transform PrismTransform;
    public Transform ConeTransform;
    public Transform SphereTransform;
    public bool IsTrue=false;


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            CorrectText.gameObject.SetActive(true);
            FalseText.gameObject.SetActive(false);
            IsTrue = true;  
        }
        else
        {

            CorrectText.gameObject.SetActive(false);
            FalseText.gameObject.SetActive(true);
            IsTrue=false;
            

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
            
        }
        else if ((gameObject.CompareTag("Prism")))
        {
            gameObject.transform.position = PrismTransform.transform.position;
        }
    }

}
