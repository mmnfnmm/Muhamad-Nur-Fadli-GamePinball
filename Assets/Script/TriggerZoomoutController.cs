using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomoutController : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider bola;
    public CameraController cameraController;

    public void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.GoBackToDefault();
        }
    }

    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
