using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Cria o cooldown e compara com o tempo necessário pro prox cachorro
    private float cooldown = 2f;
    private float nextSpawnTime = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextSpawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            nextSpawnTime = Time.time + cooldown;
        }
    }
}