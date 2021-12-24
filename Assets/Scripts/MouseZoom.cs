using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseZoom : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera cam;
    public float Targetzoom=3;
    private float scrolldata;
    public float zoomspeed=3;
    void Start()
    {
        cam=GetComponent<Camera>();
        Targetzoom=cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        scrolldata=Input.GetAxis("Mouse ScrollWheel");
        Targetzoom=Targetzoom-scrolldata;
        Targetzoom=Mathf.Clamp(Targetzoom,3,6);
        cam.orthographicSize=Mathf.Lerp(cam.orthographicSize, Targetzoom,Time.deltaTime*zoomspeed);
    }
}
