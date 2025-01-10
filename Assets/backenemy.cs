using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class backenemy : MonoBehaviour
{
    


    [SerializeField]
    private Transform spawnpoint;
    public float eulerEuler = 20;//20µµ·Î ¿Å±è


    public GameObject targetmazzle;

    private void Start()
    {
       

    }


    void Update()
    {
        
    

        
        
        transform.RotateAround(targetmazzle.transform.position, Vector3.forward, eulerEuler * Time.deltaTime);
        




    }
}
