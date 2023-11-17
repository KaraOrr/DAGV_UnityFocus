/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class junkscript : MonoBehaviour
{

//sliders:
//stamina bar
    public float stamina;
    float maxStamina;
    public float dValue;
    public Slider staminaBar;

//script:
    private void slider()
    {
        if(MyInput.GetKeyDown(KeyCode.leftShift))
        {
           DecreaseEnergy();
        }
    
        else if(stamina!=maxStamina)
        {
           IncreaseEnergy();
        }
        staminaBar.value = stamina;
    }
    private void DecreaseEnergy()
    {
        if(stamina!=0)
           stamina -= dValue * Time.deltaTime;
    }
        private void IncreaseEnergy()
    {
        if(stamina!=0)
           stamina += dValue * Time.deltaTime;
    }
        private void Start()
    {
        maxStamina = stamina;
        staminaBar.value = maxStamina;

        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;

        startYScale = transform.localScale.y;
    }
    */