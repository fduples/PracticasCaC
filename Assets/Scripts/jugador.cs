using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Declaro la calse con el mismo nombre que tiene el gameObjet al que estoy haciendo referencia
public class jugador : MonoBehaviour
{   
    public float speed = 5.0f;
    private Rigidbody rb;
    public string primerValor;
  
    public const string segundoValor = "Aguante ";
    [SerializeField]
    private string resultados;
    
    
    
    //El método awake es anterior al metodo start
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        resultados = primerValor + segundoValor;
        Debug.Log("El resultado de la suma es: " + resultados);
    }

    //El método update se llama en cada frame del juego
    private void Update()
    {
        /* Asigno primer a las valriable muevevertical y mueve horizontal los valores que nos vengan de los inputs
         Horizontal y Vertical de unity.
        Luego utilizando la clase Vector3 que crea los 3 ejes de un gameObjet se le asignan los valores en el orden
        X, Y, Z
         */
        float mueveHorizontal = Input.GetAxis("Horizontal");//Recibo lo que vienen en en input
        float mueveVertical = Input.GetAxis("Vertical");//Recibo lo que vienen en en input
        Vector3 movimiento = new Vector3(mueveHorizontal*speed, rb.velocity.y, mueveVertical*speed);
        //Asignamos el vector al regidbody
        rb.velocity = movimiento;


        
    }
}

/*
    //Declaro una variable con el componente al que la estoy asignando
    public Rigidbody rigidbody;

    //Declaro una variable de tipo MeshRenderer para manipular ese componente
    private MeshRenderer meshrender;

    // Start is called before the first frame update
    void Start()
    { 
        //Utilizo la variable declarada para controlar las acciones del componente
        rigidbody.useGravity = true;
        Debug.Log("Hola Gatos!");

        //A diferencia del la variable usada para manipular el rigisbody esta es privada asi que le debo asignar el objeto
        meshrender = GetComponent<MeshRenderer>();
        meshrender.enabled = true;
    }

     Update is called once per frame
    void Update()
    {
        
    }
    */
