using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveandDesactive : MonoBehaviour
{

    public GameObject ocjectActivateAndDesactive;

    public PaddleController mypaddleController;
    
    public InteligenciaArtificial myinteligenciaArtificial;

    // Start is called before the first frame update
    void Start()
    {
       
    }
     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //ocjectActivateAndDesactive.SetActive(false);
            mypaddleController.enabled = false;
            myinteligenciaArtificial.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //ocjectActivateAndDesactive.SetActive(true);
            mypaddleController.enabled = true;
            myinteligenciaArtificial.enabled = false;
        }
        
    }
}
