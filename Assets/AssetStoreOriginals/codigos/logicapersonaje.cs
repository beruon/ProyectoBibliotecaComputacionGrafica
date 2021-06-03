using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicapersonaje : MonoBehaviour
{
    public float velocidadmovimiento=5.0f;
    public float velocidadrotacion=200.0f;
    private Animator anim;
    public float x,y;
    public bool modelo;
    // Start is called before the first frame update
    public GameObject UILibros;
    public int Aux;

    void Start()
    {
        anim=GetComponent<Animator>();
        modelo=false;
        Aux = 0;
    }
    void FixedUpdate()
    {
        transform.Rotate(0,x*Time.deltaTime*velocidadrotacion,0);
        transform.Translate(0,0,y*Time.deltaTime*velocidadmovimiento);
    }
    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");

        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);

        if(Input.GetKeyDown(KeyCode.M))
        {
            anim.SetBool("modele",true);
            anim.SetBool("Nomodele",false);

        }
        
        if(Input.GetKeyDown(KeyCode.N))
        {
            anim.SetBool("Nomodele",true);
            anim.SetBool("modele",false);
        }
        
        if(UILibros.activeSelf == true && Aux == 0)
        {
            anim.SetBool("Leyendo",true);
            velocidadmovimiento = 0f;
            velocidadrotacion = 0f;
            Aux = 1;
        }
        if(UILibros.activeSelf == false)
        {
            anim.SetBool("Leyendo",false);
            velocidadmovimiento = 3f;
            velocidadrotacion = 200f;
        }

        if(Aux == 1 && Input.GetKeyDown(KeyCode.Escape) /*.GetMouseButtonDown(1)*/)
        {
            UILibros.SetActive(false);
            Aux = 0;
        }

        
    }
}
