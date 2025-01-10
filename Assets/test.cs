using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    private void Update()
    {


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Plane plane = new Plane(Vector3.forward, 0);

        if (plane.Raycast(ray, out float distance))
        {
            Vector3 targetPosition = ray.GetPoint(distance);

            Vector3 direction = targetPosition - transform.position;
            direction.z = 0;

            transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
        }



    }

    //private void Update()
    //{

    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    Vector3 targetPosition = ray.origin;
    //    targetPosition.z = 0;
    //    transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
    //}





}





