using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    #region Exposed

    public float m_speed = 30f;

    #endregion
   
    #region Unity Lifecycle

    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        //transform.forward : l'avant d'un objet +Z
        //transform.right : la droite d'un objet +X
        //transform.up : le dessus de l'objet +Y
        
        _rigidbody.velocity = transform.forward * m_speed;

        //gameObject : le Game Object sur lequel est attaché ce component (BUlletMovement)
        Destroy( gameObject, 5f );
    }

    void Update()
    {
        
    }
   
    void FixedUpdate(){
        
    }

    private void OnTriggerEnter( Collider other )
    {
        //La balle a touché un autre Collider
        Destroy( gameObject );
    }

    #endregion

    #region Main Methods
    #endregion

    #region Privates & Protected

    private Rigidbody _rigidbody;

    #endregion

}