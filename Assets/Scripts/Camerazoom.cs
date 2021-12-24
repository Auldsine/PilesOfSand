using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerazoom : MonoBehaviour
{
    private Camera Cam;
    public float ZoomSpeed;
    public KeyCode ZButton;

    // Start is called before the first frame update
    void Start()
    {
        Cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FixedUpdate()
    {
        if(Input.GetKey(ZButton))
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 4, Time.deltaTime * ZoomSpeed);
        }
        else
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 6, Time.deltaTime * ZoomSpeed);
        }
    }
}