using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_pattern : MonoBehaviour
{
   // Bullets Settings
   public int numBullets;
   public float speed;
   public int bulletsPerSecond = 1;
   public GameObject Bullet;

   private Vector3 startPoint;
   private const float radius = 1F;
   private float firetime;
   private float fireHoldOff;

    // Update is called once per frame
    void Update()
    {
        firetime = 1f / bulletsPerSecond;
        fireHoldOff -= Time.deltaTime;

        startPoint = transform.position;
        SpawnBullet(numBullets);
    }

    private void SpawnBullet(int totalBullets) {
        float angleStep = 360f / totalBullets;
        float angle = 0f;

        for (int i = 0; i <= totalBullets; i++) {
            float bulletDirXPosition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float bulletDirYPosition = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

            Vector3 bulletVector = new Vector3(bulletDirXPosition, bulletDirYPosition, 0);
            Vector3 bulletMoveDirection = (bulletVector - startPoint).normalized * speed;

            GameObject tmpObject = Instantiate(Bullet, startPoint, Quaternion.identity);
            tmpObject.GetComponent<Rigidbody>().velocity = new Vector3(bulletMoveDirection.x, 0, bulletMoveDirection.y);

            Destroy(tmpObject, 10F);

            angle += angleStep;
        }
    }
}
