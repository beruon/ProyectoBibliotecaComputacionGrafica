using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cam2 : MonoBehaviour
{

    public GameObject pj;


    private float DetRotation(float r){
        return 360*r;
    }

    private float IndR(){
        return GameObject.Find("Slider_r").GetComponent<Slider>().value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(pj.transform);
        
    }
}
