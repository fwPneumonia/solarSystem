using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour
{
    public GameObject sun;
    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;

    public float speedMercury;
    public float speedVenus;
    public float speedEarth;
    public float speedMars;
    public float speedJupiter;
    public float speedSaturn;
    public float speedUranus;
    public float speedNeptune;
    
    void Start()
    {
        mercury = GameObject.Find("mercury");
        venus = GameObject.Find("venus");
        earth = GameObject.Find("earth");
        mars = GameObject.Find("mars");
        jupiter = GameObject.Find("jupiter");
        saturn = GameObject.Find("saturn");
        uranus = GameObject.Find("uranus");
        neptune = GameObject.Find("neptune");

    }

    // Update is called once per frame
    void Update()
    {
        mercury.transform.RotateAround(transform.position, new Vector3(0,0,1), speedMercury*Time.deltaTime);
        venus.transform.RotateAround(transform.position, new Vector3(0,0,1), speedVenus*Time.deltaTime);
        earth.transform.RotateAround(transform.position, new Vector3(0,0,1), speedEarth*Time.deltaTime);
        mars.transform.RotateAround(transform.position, new Vector3(0,0,1), speedMars*Time.deltaTime);
        jupiter.transform.RotateAround(transform.position, new Vector3(0,0,1), speedJupiter*Time.deltaTime);
        saturn.transform.RotateAround(transform.position, new Vector3(0,0,1), speedSaturn*Time.deltaTime);
        uranus.transform.RotateAround(transform.position, new Vector3(0,0,1), speedUranus*Time.deltaTime);
        neptune.transform.RotateAround(transform.position, new Vector3(0,0,1), speedNeptune*Time.deltaTime);
        
    }
}
