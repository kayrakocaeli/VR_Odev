using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PrismTransform : MonoBehaviour
{
    public Transform TargetTransform;
    public bool IsTrue=false;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Sphere") || other.CompareTag("Cone"))
        {
            IsTrue = true;
        }
        else
        {
            IsTrue=false;
        }
    }
    
    public void Update()
    {
        if(transform.position==TargetTransform.position)
        {
            IsTrue = false;
        }
        ReturnToInitialPositionUpdate();
    }


    public void ReturnToInitialPosition()
    {
        transform.position = TargetTransform.position;
        transform.rotation = TargetTransform.rotation;
    }
    public void ReturnToInitialPositionUpdate()
    {
        if (IsTrue)
        {
            transform.position = TargetTransform.position;
            transform.rotation = TargetTransform.rotation;
        }
       
    }
}
