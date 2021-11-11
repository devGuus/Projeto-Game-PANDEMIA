using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawCar : MonoBehaviour
{
    public GameObject Car;
    public float spawCarros;

    private float nextSpawn = 0f;

    // Update is called once per frame
    void Update(){

        if (Time.time > nextSpawn){

            nextSpawn = Time.time + spawCarros;

            Instantiate(Car, transform.position, Car.transform.rotation);
        }     
    }
}
