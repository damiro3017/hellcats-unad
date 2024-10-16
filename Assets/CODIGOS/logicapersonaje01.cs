using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicapersonaje01 : MonoBehaviour
{
    public float velocidadMovimeinto = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;



    public Rigidbody rb;
    public float fuerzaDeSalto = 8f;
    public bool puedoSaltar;

    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimeinto);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");



        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

    }
}
   