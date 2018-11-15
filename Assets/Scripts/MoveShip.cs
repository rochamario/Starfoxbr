using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{

    public float moveSpeed = 500.0f;
    public int inverter = -1; // Negativo = inverter, Positivo = não inverter


    // Use this for initialization
    void Start()
    {
        ScoreManager.Instance.LevelChanged += LevelChanged;
    }

    private void OnDestroy()
    {
        ScoreManager.Instance.LevelChanged -= LevelChanged;

    }

    private void OnDisable()
    {
        ScoreManager.Instance.LevelChanged -= LevelChanged;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += (new Vector3(Input.GetAxis("Horizontal"), inverter*Input.GetAxis("Vertical"),0)) * moveSpeed*Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, inverter * vertical, 0);
        Vector3 finalDirection = new Vector3(horizontal, inverter * vertical, 5.0f);

        transform.position += direction * moveSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(finalDirection), Mathf.Deg2Rad * 50.0f);   
        
    }

    void LevelChanged(int newlevel)
    {
        Debug.Log("Movimento da nave, evento de novo level recebido!");
    }
}
