using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class backenemy : MonoBehaviour
{
    


    [SerializeField]
    private Transform spawnpoint;
    public float eulerEuler = 20;//20µµ·Î ¿Å±è


    public GameObject targetmazzle;

    public float speed = 0.001f;

    GameObject asd;
    GameObject asd22;

    private void Start()
    {
        asd = gameObject;


    }


    void Update()
    {
        transform.RotateAround(targetmazzle.transform.position, Vector3.forward, eulerEuler * Time.deltaTime);


        //var bbb = (targetmazzle.transform.position - transform.position).normalized;
        //asd.GetComponent<Rigidbody2D>().AddForce(bbb * speed, ForceMode2D.Impulse);

        ////transform.Translate(-bbb * speed);

        transform.Translate(new Vector2(speed, 0));





    }
}
