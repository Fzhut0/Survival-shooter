using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFov = 60f;
    [SerializeField] float zoomedInFov = 20f;
    [SerializeField] float zoomedOutSens = 2f;
    [SerializeField] float zoomedInSens = 0.5f;

    FirstPersonController fpsController;



    bool zoomedInToggle = false;


    private void Start()
    {
        fpsController = GetComponent<FirstPersonController>();
    }

    private void Update()
    {
        ZoomIn();
    }
    void ZoomIn()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFov;
                fpsController.m_MouseLook.XSensitivity = zoomedInSens;
                fpsController.m_MouseLook.YSensitivity = zoomedInSens;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFov;
                fpsController.m_MouseLook.XSensitivity = zoomedOutSens;
                fpsController.m_MouseLook.YSensitivity = zoomedOutSens;

            }


        }
    }
}
