using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    [SerializeField] public float Mass, Grav,ElInfierno;
    [SerializeField] public Vector3 Axel, Velocirraptor,Dinosplacement;
    [SerializeField] public Transform Megatron;
    
    // Start is called before the first frame update
    void Start()
    {
        Megatron = GetComponent<Transform>();
    }
    void Update()
    {
        Axel = Vector3.zero;
      Hermes(new Vector3(0, Grav, 0));
       Sisiphus();
        NeoEspacio();
    }
    void Sisiphus()
    {
        Velocirraptor += Axel * Time.deltaTime;
        Dinosplacement = Velocirraptor * Time.deltaTime;
        Megatron.position = Megatron.position + Dinosplacement;

    }
    public void Hermes(Vector3 Sigma)
    {
        Axel += Sigma / Mass;
    }
    void NeoEspacio()
    {
        if (Megatron.position.y < ElInfierno)
                Megatron.position = new Vector3(Megatron.position.x, ElInfierno, Megatron.position.z);
    
    }


    // Update is called once per frame

}
