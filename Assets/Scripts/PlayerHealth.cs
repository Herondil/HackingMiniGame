using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    #region Exposed

    [SerializeField]
    private int _initialPlayerHP = 3;

    [SerializeField]
    private IntVariable _playerHP;

    public GameObject _leftWing;
    public GameObject _rightWing;

    #endregion

    #region Unity Lifecycle

    void Awake(){
        _playerHP.m_value = _initialPlayerHP;
    }

    void Start()
    {
        //_leftWing = GameObject.Find( "Left" );
        //_rightWing = GameObject.Find( "Right" );
    }

    void Update()
    {
        
    }
   
    void FixedUpdate(){
        
    }

    private void OnCollisionEnter( Collision collision )
    {
        if( collision.gameObject.CompareTag( "Enemy" ) ) //Renvoie TRUE ou FALSE
        {
            // -- : _playerHP.m_value = _playerHP.m_value - 1;
            // ++ : _playerHP.m_value = _playerHP.m_value + 1;
            // _playerHP.m_value *= 3 : _playerHP.m_value = _playerHP.m_value * 3;
            // _playerHP.m_value /= 3 : _playerHP.m_value = _playerHP.m_value / 3;
            _playerHP.m_value--;

            if( _playerHP.m_value <= 0 )
            {
                gameObject.SetActive( false );
            }
            else if( _playerHP.m_value <= 1 )
            {
                _leftWing.SetActive( false );
            }
            else if( _playerHP.m_value <= 2 )
            {
                _rightWing.SetActive( false );
            }
        }
    }
    #endregion

    #region Main Methods
    #endregion

    #region Privates & Protected
    #endregion

}