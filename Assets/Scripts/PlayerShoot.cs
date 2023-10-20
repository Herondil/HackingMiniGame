using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    #region Exposed

    public GameObject _bulletPrefab;

    public float m_fireRate = 0.33f;//Temps en seconde entre 2 tirs

    #endregion
   
    #region Unity Lifecycle

    void Awake(){
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        //Pour tirer tu dois appuyer sur le bouton ET que le temps dans le jeu soit plus grand que le temps PLUS la cadence de tir
        if( Input.GetAxisRaw("R2Axis") < 0.6 && Time.timeSinceLevelLoad > _nextTimeToShoot )
        {
            //Time.timeSinceLevelLoad : Temps écoulé depuis le lancement de la Scene
            //Time.time : Temps écoulé depuis le lancement de l'application
            _nextTimeToShoot = Time.timeSinceLevelLoad + m_fireRate;
            Instantiate( _bulletPrefab, transform.position, transform.rotation );
        }
    }
   
    void FixedUpdate(){
        
    }

    //Pour les colliders notTrigger
    private void OnCollisionEnter( Collision collision )
    {
        
    }

    //Pour les colliders isTrigger
    private void OnTriggerEnter( Collider other )
    {
        Debug.Log( "Quelqu'un m'a touché" );
    }

    #endregion

    #region Main Methods
    #endregion

    #region Privates & Protected

    private float _nextTimeToShoot = 0f;

    #endregion

}