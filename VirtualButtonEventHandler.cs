using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VirtualButtonEventHandler : MonoBehaviour, IVuforiaButtonEventHandler
{
    public GameObject vb;
    public Animator ani;
    // Use this for initialization
    void Start()
    {
        VirtualButtonBehaviour vbb = vb.GetComponent<VirtualButtonBehaviour>();
        if (vbb)
        {
            vbb.RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
