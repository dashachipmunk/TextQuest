﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextQuest : MonoBehaviour
{
    public Text content;
    public Text titleText;
    public Text location;

    public Steps startStep;
    public Steps currentStep;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        titleText.text = "Почему закрыто метро?";
        location.text = startStep.locate;
        content.text = startStep.content;
        image.sprite = startStep.sprite;
        currentStep = startStep;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
            
        //    content.text = currentStep.nextStep1.content;
        //    location.text = currentStep.nextStep1.locate;
        //    image.sprite = currentStep.nextStep1.sprite;
        //    currentStep = currentStep.nextStep1;
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{

        //    content.text = currentStep.nextStep2.content;
        //    location.text = currentStep.nextStep2.locate;
        //    image.sprite = currentStep.nextStep2.sprite;
        //    currentStep = currentStep.nextStep2;
        //}
        //if (true)
        //{

        //}

    }
    public void BRight()
    {
        content.text = currentStep.nextStep2.content;
        location.text = currentStep.nextStep2.locate;
        image.sprite = currentStep.nextStep2.sprite;
        currentStep = currentStep.nextStep2;
    }
    public void BLeft()
    {
        content.text = currentStep.nextStep1.content;
        location.text = currentStep.nextStep1.locate;
        image.sprite = currentStep.nextStep1.sprite;
        currentStep = currentStep.nextStep1;
    }
}
