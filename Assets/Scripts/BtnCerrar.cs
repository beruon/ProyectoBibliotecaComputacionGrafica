using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCerrar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UILibros;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cerrar()
    {
        UILibros.SetActive(false);
    }
}
