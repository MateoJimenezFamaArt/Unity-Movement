using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Elfaisan es el nombre del vector
    [SerializeField] Vector3 ElFaisan;
    //Transfrom siendo playerPos es bindear los datos de transfomr a la variable playerPos
    [SerializeField]Transform playerPos;
    //Asuncion relaciona velocidad de manera inversamente proporcioinal
    [SerializeField] int Asuncion, Sprint;
    [SerializeField] float True,LegStrenght;
    [SerializeField] bool Loko;
    [SerializeField] Gravity DARKHOLEEE;


    // Start is called before the first frame update
    void Start()
    {
        //playerPos = GetComponent<Transofrm> hace referencia a tomar el componente de transform del objeto y relacionarlo a la variable
        playerPos = GetComponent<Transform>();
        DARKHOLEEE = GetComponent<Gravity>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jumpy();

    }

    //Crear nuestro propio metodo

    // Void = No devolver nada

    private void Move()
    { // MOVIMIENTO HORIZONTAL
        //Si esta llendo derecha o izquierda
        True = Input.GetAxis("Horizontal");
        Loko = Input.GetKey(KeyCode.Space);

        //Input works to see what is the input going in the program
        //GetButton works to read as a bool if a button was pressed for a single frame or multiple
        //() Is where we asign the character that we will be setting in order to get activation from that ButtonDown.
        //Must add the parameter in the () as a Str AKA ""

        //Mirando si preciona un boton
        if (Input.GetButton("Horizontal")) 
        {
                    while (!Loko) 
                    {
                    Sprint = 1;

                break;
                    }
                    while (Loko) 
                    {
                    Sprint = 2;
                break;
                    }
       
            // playerPos.position se usa el .position para extraer de transform la psocicion en particular del item
            playerPos.position += (ElFaisan*True)*Sprint / Asuncion;
        }

    

    }
    //MOVMIENTO VERTICAL

    void Jumpy()
    {
        if (Input.GetKey(KeyCode.C))
        {
            DARKHOLEEE.Velocirraptor.y = (DARKHOLEEE.Velocirraptor.y * -1f);
        }
        
    }

}

