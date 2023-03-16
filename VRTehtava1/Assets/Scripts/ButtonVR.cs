using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public GameObject presser;
    public GameObject ball;
    public GameObject basket;
    public Score scoreSystem;
    bool isPressed;
    Vector3 basketPosition;
    Vector3 basketMovement = new Vector3(0, 0.75f, 0);
    Vector3 buttonPosition;
    Vector3 buttonMovement = new Vector3(0, 0.03f, 0);

    private void Awake()
    {
        buttonPosition = button.transform.position;
        basketPosition = basket.transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.position = buttonPosition - buttonMovement;
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser)
        {
            button.transform.position = buttonPosition;
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SpawnBall()
    {
        Vector3 position = new Vector3(8.5f, 1, 0);
        GameObject ballInstance = Instantiate(ball, position, Quaternion.identity);
    }

    public void BasketLow()
    {
        basket.transform.position = basketPosition;
    }

    public void BasketMid()
    {
        basket.transform.position = basketPosition + basketMovement;
    }

    public void BasketHigh()
    {
        basket.transform.position = basketPosition + 2*basketMovement;
    }

    public void ResetScore()
    {
        scoreSystem.Reset();
    }

}
