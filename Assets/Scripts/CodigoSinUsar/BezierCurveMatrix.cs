using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[ExecuteInEditMode]
public class BezierCurveMatrix : MonoBehaviour
{

    [Header("Puntos")]
    public Transform p0;
    public Transform p1;
    public Transform p2;
    public Transform p3;

    [Header("Geometria")]
    public GameObject resultPrefab;
    // public Camera camara;

    [Header("Parametrizacion")]
    [Range(0.0f, 1.0f)]
    public float t;

    private GameObject instance;

    Vector4 PMT =new Vector4();


    Vector4 GetBezier(Vector3 p0, Vector3 p1, Vector3 p3, Vector3 p4, float t)
    {
        Matrix4x4 P = new Matrix4x4();

        P.SetColumn(0, p0);
        P.SetColumn(1, p1);
        P.SetColumn(2, p3);
        P.SetColumn(3, p4);


        Matrix4x4 M = new Matrix4x4();

        M.SetColumn(0, new Vector4(1, 0, 0, 0));
        M.SetColumn(1, new Vector4(-3, 3, 0, 0));
        M.SetColumn(2, new Vector4(3, -6, 3, 0));
        M.SetColumn(3, new Vector4(-1, 3, -3, 1));


        float tt = t * t;
        float ttt = tt * t;

        Vector4 T = new Vector4(1, t, tt, ttt);

        Vector4 MT = M * T;
        PMT = P * MT;
    
        return PMT;
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = Instantiate(resultPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.DrawLine(p0.position, p1.position );
        // Debug.DrawLine(p1.position, p2.position );
        // Debug.DrawLine(p2.position, p3.position); 
        t = GameObject.Find("Slider_t").GetComponent<Slider>().value;
        
        instance.transform.position = GetBezier(p0.position, p1.position,  p2.position, p3.position, t);
    }
}
