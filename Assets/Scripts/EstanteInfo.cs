using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.UIElements;

public class EstanteInfo : MonoBehaviour
{
    public int Seccion = 0; //innecesario pero bueh

    public static EstanteInfo instance;
    private Image[] images;
    
    public GameObject UILibros;
    
    void Start()
    {
        // UILibros = GameObject.Find("UILibros");
        // Debug.Log(UILibros);
        images = new Image[10];
        UILibros.SetActive(false);
    }

    private void Update()
    {
        // OnMouseDown();
    }

    void OnMouseDown()
    {
        // Debug.Log(Seccion);
        // Debug.Log(gameObject.name);
        // Debug.Log(UILibros);
        if(UILibros.activeSelf== false)
        {
            UILibros.SetActive(true);
            AdicionarLibros(gameObject.name);
        }
    }



    private void AdicionarLibros(string nombre)
    {
        
        for(var i = 1; i <= images.Length; i++)
        {
            var img = "Imagen"+i;
            
            images[i-1] = GameObject.Find(img).GetComponent<Image>();
            
            var ruta = "Sprites/Libros/"+nombre+"/"+i;
            // var ruta = nombre+i;
            
            images[i-1].sprite = Resources.Load<Sprite>(ruta);
           
        }

        GameObject.Find("TextoSeccion").GetComponent<Text>().text = "Sección "+Seccion;
        
    }

}
