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
        // Detectar si se presiona el botón izquierdo del ratón
        if (Input.GetMouseButtonDown(1)) // 0 es el botón izquierdo del ratón
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar una nueva bala en la posición y rotación del firePoint
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
