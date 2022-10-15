using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movplatscript : MonoBehaviour
{ 
    [SerializeField]GameObject[] waypoints;
    int currentindex=0;
    float speed=5f;

    void Update()
    { if(Vector3.Distance(transform.position,waypoints[currentindex].transform.position)<1f){
        currentindex++;
        if(currentindex>=waypoints.Length){
            currentindex=0;
        }}
        transform.position=Vector3.MoveTowards(transform.position,waypoints[currentindex].transform.position,speed*Time.deltaTime);
    }
    }
