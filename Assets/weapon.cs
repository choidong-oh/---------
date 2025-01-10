using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class weapon : MonoBehaviour
{

    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private GameObject prefab2;

    [SerializeField]
    private Transform spawnpoint;
    [SerializeField]
    private Transform spawnpoint2;

    public int speed = 5;
    public float timedelay;
    public float cooltime = 2f;

    private void Start() 
    {
        timedelay = cooltime;
    }

    


    private void Update()
    {
        timedelay += Time.deltaTime;

        if (timedelay > cooltime)
        {
            GameObject clone = Instantiate(prefab, spawnpoint.position, Quaternion.identity );
            var asd = clone.GetComponent<Rigidbody2D>();
            var ggg = transform.rotation.eulerAngles.z;
            
            //Debug.Log(ggg);

            
            

            //clone.transform.Rotate(new Vector3(0, 0, ggg));
            clone.transform.rotation = Quaternion.Euler(0, 0, ggg);
            //clone.transform.rotation = new Quaternion(0, 0, transform.rotation.z, 0);

            asd.AddForce(transform.up * speed, ForceMode2D.Impulse);
            //asd.AddTorque(10, ForceMode2D.Impulse);
            timedelay = 0;
        }



        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone = Instantiate(prefab2, spawnpoint2.position, Quaternion.identity);
            var asd = clone.GetComponent<Rigidbody2D>();
            asd.AddForce(transform.right * speed, ForceMode2D.Impulse);
            asd.AddTorque(10, ForceMode2D.Impulse);
            //asd.AddForce(transform.right * speed,ForceMode2D.Impulse);
        }



    }



}
