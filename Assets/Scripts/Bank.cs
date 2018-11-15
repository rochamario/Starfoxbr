using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public float doubleTapDelay = 0.2f;
    public float barrelRollDuration = 1.0f;

    private float time = float.MaxValue;
    private bool buttonDown = false;
    private bool inBarrelRoll = false;


    // Update is called once per frame
    void Update()
    {
        if (!inBarrelRoll)
        {

            float bankAxis = Input.GetAxis("Bank");

            Vector3 newRotationEuler = transform.rotation.eulerAngles;
            newRotationEuler.z = -90 * Input.GetAxis("Bank");
            Quaternion newQuat = Quaternion.identity;
            newQuat.eulerAngles = newRotationEuler;
            transform.rotation = newQuat;

            if (bankAxis == 0.0f)
            {
                buttonDown = false;
            }
            else if (buttonDown == false)
            {
                buttonDown = true;
                if (time < doubleTapDelay)
                {
                    StartCoroutine("BarrelRollLeft");
                }
                time = 0.0f;
            }

            time += Time.deltaTime;
        }
    }

    IEnumerator BarrelRollLeft()
    {
        inBarrelRoll = true;
        float t = 0.0f;

        Vector3 initialRotation = transform.localRotation.eulerAngles;
        Vector3 goalRotation = initialRotation;
        goalRotation.z += 180.0f;

        Vector3 currentRotation = initialRotation;

        //  Quaternion originalRotation = transform.rotation;
        //  Quaternion goalRotation = originalRotation;
        // goalRotation.eulerAngles = new Vector3(goalRotation.eulerAngles.x, goalRotation.eulerAngles.y, goalRotation.eulerAngles.z + 180.0f);

        while (t < barrelRollDuration/2.0f)
        {
            currentRotation.z = Mathf.Lerp(initialRotation.z, goalRotation.z, t / (barrelRollDuration / 2.0f));
            transform.localRotation = Quaternion.Euler(currentRotation);
            //transform.rotation = Quaternion.Lerp(originalRotation, goalRotation, t / (barrelRollDuration / 2.0f));
            t += Time.deltaTime;
            yield return null;
        }

       // goalRotation.eulerAngles = new Vector3(goalRotation.eulerAngles.x, goalRotation.eulerAngles.y, goalRotation.eulerAngles.z + 1.0f);
        t = 0;

        initialRotation = transform.localRotation.eulerAngles;
        goalRotation = initialRotation; 
        goalRotation.z += 180.0f;

        while (t < barrelRollDuration / 2.0f)
        {
            currentRotation.z = Mathf.Lerp(initialRotation.z, goalRotation.z, t / (barrelRollDuration / 2.0f));
            transform.localRotation = Quaternion.Euler(currentRotation);
            // transform.rotation = Quaternion.Lerp(goalRotation, originalRotation, t / (barrelRollDuration / 2.0f));
            t += Time.deltaTime;
            yield return null;
        }
        inBarrelRoll = false;
    }
}
