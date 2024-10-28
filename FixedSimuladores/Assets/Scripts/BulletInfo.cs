using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletInfo : MonoBehaviour
{
    private Vector3 startPosition;
    private float bulletSpeed;
    public Text infoText;
    private bool hasCollided = false;

    public void Setup(float speed, Text text)
    {
        startPosition = transform.position;
        bulletSpeed = speed;
        infoText = text;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!hasCollided)
        {
            hasCollided = true;

            float distance = Vector3.Distance(startPosition, transform.position);

            string collidedObject = collision.gameObject.name;

            Destroy(gameObject);
        }
    }
}
