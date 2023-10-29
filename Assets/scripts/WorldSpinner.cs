using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpinner : MonoBehaviour
{
    public GameObject Player;
    public float rotatepoint;
    private void Awake()
    {
        Input.gyro.enabled = true;
    }
    void Update()
    {
        getInputs();
        gyrocontrolls();
    }
    public void gyrocontrolls()
    {
        rotatepoint = Input.gyro.attitude.z;
        transform.RotateAround(Player.transform.position, new Vector3(0, 0, 1), Input.gyro.attitude.z - rotatepoint);
    }
    public void getInputs()
    {
        if (Input.GetKeyDown("a") == true || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(spin(true));
        }
        if (Input.GetKeyDown("d") == true || Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(spin(false));
        }

    }
    public IEnumerator spin(bool clockwise)
    {
        for(int i = 0; i < 90; i++)
        {
            if (clockwise == true)
            {
                transform.RotateAround(Player.transform.position, new Vector3(0, 0, 1), 1f);
            }
            else
            {
                transform.RotateAround(Player.transform.position, new Vector3(0, 0, 1), -1f);
            }
            yield return new WaitForSeconds(0.001f);
        }
    }
}
