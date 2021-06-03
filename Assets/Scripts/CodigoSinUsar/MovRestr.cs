using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[ExecuteInEditMode]
public class MovRestr : MonoBehaviour
{


    [Header("Puntos")]
    public Transform p0;
    public Transform p1;
    public Transform p2;

    [Header("Personaje")]
    public GameObject pj;

    // private float r,s,f;

    private GameObject instance;

    
    private Vector3 DetPosicion(Vector3 p0, Vector3 p1, Vector3 p2, float f, float s){
        float x0 = p0.x;
        float z0 = p0.z;    
        float x = (p2.x - p0.x)*f;
        float z = (p1.z - p0.z)*s;
        
        return new Vector3 (x0 + x, p0.y, z0 + z);
    }

    private float DetRotation(float r){
        return 360*r;
    }

    private float IndR(){
        return GameObject.Find("Slider_r").GetComponent<Slider>().value;
    }

    private float IndS(){
        return GameObject.Find("Slider_s").GetComponent<Slider>().value;
    }

    private float IndF(){
        return GameObject.Find("Slider_f").GetComponent<Slider>().value;
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = Instantiate(pj);
    }

    // Update is called once per frame
    void Update()
    {
        instance.transform.position = DetPosicion(p0.position, p1.position, p2.position, IndF(), IndS());
        // Debug.Log(DetPosicion(p0.position, p1.position, p2.position, IndF(), IndS()));
    }
}
