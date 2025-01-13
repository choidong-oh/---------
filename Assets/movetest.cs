using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetest : MonoBehaviour
{
    private void Update()
    {
        //카메라 내 좌표값을 사용할수 있게함
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mouse);
        transform.position = mouse;
    }
}
