
using System;
using Script.Particle;
using Unity.VisualScripting;
using UnityEngine;


namespace Script
{
    public class MovingPlayer : MonoBehaviour
    {
        [Header("Dead Canvace")]
        [SerializeField] private UIManager _uiManager;

    
        [SerializeField] private SettingsPlayer _player;
        [SerializeField] private PlayerHPAndLife playerHP;


       


        private void Update()
        {
            if (playerHP.LifePlayer != 0)
            {
                
                _player.MovingPlayerandJump();
                _player.RotatePlayerMoving();
            }
            else
            {
                _uiManager.ActiveCanvaceDeadMenu();
            }
            
                
            

            if (Input.GetKey(KeyCode.Escape))
            {
                _uiManager.ActiveCanvaceMineMenuKey();
            }
                
            
        }

        
            
        
    }
}