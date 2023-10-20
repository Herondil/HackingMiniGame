using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Exposed

    public float m_speed = 10f;

    #endregion

    #region Unity Lifecycle

    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
    
    }

    void Update()
    {
        /*
        float horizontal = Input.GetAxisRaw( "Horizontal" );
        _direction.x = horizontal;
        float vertical = Input.GetAxisRaw( "Vertical" );
        _direction.x = vertical;
        */

        //X représente la gauche et la droite dans notre jeu
        _direction.x = Input.GetAxisRaw( "Horizontal" );
        //Z représente le haut et le bas dans notre jeu
        _direction.z = Input.GetAxisRaw( "Vertical" );

        _orientationInput.x = Input.GetAxisRaw( "RightStickX" );
        _orientationInput.z = Input.GetAxisRaw( "RightStickY" );
    }

    private void FixedUpdate()
    {
        //La vélocité est la direction et la vitesse de déplacement du Player
        _rigidbody.velocity = _direction * m_speed;

        if( _orientationInput != Vector3.zero )//oI.x != 0 && oI.y != 0 && oI.z != 0
        //if( _orientationInput.magnitude > 0f )
        {
            Quaternion rotation = Quaternion.LookRotation( _orientationInput );
            _rigidbody.MoveRotation( rotation );
        }
    }

    private void OnTriggerEnter( Collider other )
    {
        Debug.Log( "Je suis entré dans un Trigger" );
    }

    #endregion

    #region Main Methods

    #endregion

    #region Private & Protected

    //Cette variable stocke la direction du mouvement du joueur
    private Vector3 _direction = new Vector3();//Vector3(0,0,0)

    private Vector3 _orientationInput = new Vector3();

    private Rigidbody _rigidbody;

    #endregion
}