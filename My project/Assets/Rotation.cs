using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]float RotX;
    [SerializeField]float Roty;
    [SerializeField]float RotZ;
    void Update(){
        transform.Rotate(360*RotX*Time.deltaTime,360*Roty*Time.deltaTime,360*RotZ*Time.deltaTime);
    }
}

