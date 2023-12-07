using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeTranform : MonoBehaviour
{
    public Transform TargetTransform;
    public bool IsTrue = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Prism") || other.CompareTag("Sphere"))
        {
            IsTrue = true;
        }
        else
        {
            IsTrue = false;
        }
    }


    public void Update()
    {
        if (transform.position == TargetTransform.position)
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
