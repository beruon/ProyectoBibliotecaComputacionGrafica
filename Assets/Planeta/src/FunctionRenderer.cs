using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionRenderer : MonoBehaviour
{
    public Function fun;
    
    public float speed = 1;
    public float limitInf = -10;
    public float limitSup = 10;
    private FunctionTemplate factory;
    float signo = 1;
    float index = 0;
    private void Start(){
       this.factory = FunctionFactory.CreateFunctionFilter(fun);
    }

    private void Update(){
        index += Time.deltaTime * signo * speed;
        float x = index;
        float y = factory.Evaluate(index);
        float z = transform.position.z;

        if(index > limitSup) signo = -1;
        if(index < limitInf) signo = 1;

        transform.localPosition= new Vector3(x,y,z);
    }

}