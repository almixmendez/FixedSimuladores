using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab de la bala
    public Transform firePoint; // Punto de origen desde donde se disparan las balas
    public float bulletSpeed = 20f; // Velocidad de la bala

    void Update()
    {
        // Detectar si se presiona el bot�n izquierdo del rat�n
        if (Input.GetMouseButtonDown(1)) // 0 es el bot�n izquierdo del rat�n
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar una nueva bala en la posici�n y rotaci�n del firePoint
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Obtener el Rigidbody de la bala para aplicarle una fuerza
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = firePoint.forward * bulletSpeed; // Aplicar velocidad hacia adelante
        }

        Destroy(bullet, 1f);
    }
}
