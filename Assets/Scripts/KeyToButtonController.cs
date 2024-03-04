using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyToButtonController : MonoBehaviour
{
    [Header("Start Train Button")]
    public Button StartTrainButton;
    public KeyCode StartTrainKey = KeyCode.Return;

    [Header("Start Test Button")]
    public Button StartTestButton;
    public KeyCode StartTestKey = KeyCode.Space;

    [Header("Continue Button")]
    public Button ContinueButton;
    public KeyCode ContinueKey = KeyCode.Space;

    [Header("Interrupt Button")]
    public Button InterruptButton;
    public KeyCode InterruptKey = KeyCode.Return;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(StartTrainKey))
        {
            StartTrainButton.onClick.Invoke();
        }

        if (Input.GetKeyDown(StartTestKey))
        {
            StartTestButton.onClick.Invoke();
        }

        if (Input.GetKeyDown(ContinueKey))
        {
            ContinueButton.onClick.Invoke();
        }

        if (Input.GetKeyDown(InterruptKey))
        {
            InterruptButton.onClick.Invoke();
        }
    }
}
