using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{   Mesh mesh;

    Vector3[] vertices;
    int[] triangles;
    int vertexno=0;
    int Xsize=40;
    int Zsize=40;
    // Start is called before the first frame update
    void declarer(){
    mesh=new Mesh();
        GetComponent<MeshFilter>().mesh=mesh;
        GetComponent<MeshCollider>().sharedMesh=mesh;}
    void Start()
    {
        declarer(); 
        CreateShape();
        UpdateMesh();
        
    }

    void CreateShape(){
        vertices=new Vector3[(Xsize+1)*(Zsize+1)];
        for(int i=0,z=0;z<=Zsize;z++){
            for(int x=0;x<=Xsize;x++){
                    float y=Mathf.PerlinNoise(x*.3f,z*.3f)*2f;
                    vertices[i]=new Vector3(x,y,z);
                    i++;
                }
            }
        int count=0;
        int count1=0;
        triangles=new int[Xsize*6*Zsize];
        for(int z=0;z<Zsize;z++){
        for(int x=0;x<Xsize;x++){
        
        triangles[count+0]=count1+0;
        triangles[count+1]=Xsize+1+count1;
        triangles[count+2]=count1+1;
        triangles[count+3]=count1+1;
        triangles[count+4]=Xsize+count1+1;
        triangles[count+5]=Xsize+2+count1;
        count+=6;
        count1++;}
        count1++;}}
    void UpdateMesh(){
        mesh.Clear();
        mesh.vertices=vertices;
        mesh.triangles=triangles;
        }
    void OnDrawGizmos(){
        if(vertices==null){
            return;
        }
        for(int i=0;i<vertices.Length;i++){
            Gizmos.DrawSphere(vertices[i],.1f);
        }

    }

    }

