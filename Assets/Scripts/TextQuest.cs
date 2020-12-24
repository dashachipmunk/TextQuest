using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    public Text content;
    public Text titleText;

    public Steps startStep;
    public Steps currentStep;
    void Start()
    {
        titleText.text = "Dinosaurs world";
        content.text = startStep.content;
        currentStep = startStep;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            content.text = currentStep.nextStep1.content;
            currentStep = currentStep.nextStep1;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            content.text = currentStep.nextStep2.content;
            currentStep = currentStep.nextStep2;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            
        }
    }
}
