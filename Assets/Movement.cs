using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Vitesse de déplacement
    public float speed;
    //vitesse de rotation (angular speed)

    Vector3 dir;
    float   vertical,
            horizontal;

    //référence vers le Rigidbody
    private Rigidbody bodyRef;


    // Start is called before the first frame update
    void Start()
    {
        //Merci la doc de MovePosition
        bodyRef = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis("Horizontal");

        //un vecteur 3 ça représente 2 choses 
        // V3 est une direction ?
        // V3 est une position ?

        //Input.GetAxis
        //des flottants dans [-1,1]
        

        //on veut un direction normalisée

        //normalisation, met le vecteur à la norme

        //dir = new Vector3(horizontal,0, vertical);

        //les directions sont toujours normalisées
        //dir = dir.normalized;

        //programmer un Draw Ray qui part du joueur pour aller dans la direction du stick
        //Debug.DrawRay(transform.position, dir * 5, Color.red);
    }


    private void FixedUpdate()
    {

        

        //Move Position méthode pour le kinematic rigdibdy
        //bodyRef.MovePosition(transform.position + speed * Time.fixedDeltaTime * dir);

        //modification de la vitesse
        //le rgbd n'est pas Kinematic
        //bodyRef.velocity = dir * speed;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        dir = new Vector3(horizontal, 0, vertical);

        //on calcule une orientation "vers dir"
        if (dir.magnitude != 0)
        {
            bodyRef.MovePosition(transform.position + dir.normalized * Time.fixedDeltaTime * speed);
            Quaternion q = Quaternion.LookRotation(dir);
            bodyRef.MoveRotation(q);
        }

        
    }
}
