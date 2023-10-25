using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    //le gameobject utilis� pour le projectile
    public GameObject   bulletPrefab;
    //un transform utilis� pour localiser l'endroit d'apparition du projectile
    public Transform newBulletPositionTransform;
    //un transform pour regrouper les projectiles ensemble
    public Transform newBulletGroupTransform;

    void Update()
    {
        bool shootPressed = Input.GetButtonDown("Fire1");
        if (shootPressed)
        {
            Debug.Log("Shoot !");

            //1 cr�ation du clone
            GameObject newBulletRef = Object.Instantiate(bulletPrefab);

            //2 le parent est un transform qui sera utilis� pour la position
            newBulletRef.transform.parent = newBulletPositionTransform;

            //3 la position est mise � 0 0 0, par rapport � son parent
            //localPosition est la position relative au parent
            newBulletRef.transform.localPosition = Vector3.zero;

            //3.5  on s'aligne par rapport au parent
            newBulletRef.transform.rotation = transform.rotation;

            //4 on enl�ve le parent pour ne plus dans le "player"
            //(sinon le projectile bouge en m�me temps que le parent)
            newBulletRef.transform.parent = newBulletGroupTransform;
        }
    }
}
