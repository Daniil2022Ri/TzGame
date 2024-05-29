using UnityEngine;

namespace Script.SoungManager
{
    public class SoungGameManager : MonoBehaviour
    {
        public AudioSource Source;

        [Header("Audio Player")]
        [SerializeField] private AudioClip playerTakeDamage;

        [SerializeField] private AudioClip playerDead;

        [SerializeField] private AudioClip playerMoving;

        [SerializeField] private AudioClip playerJumping;
        
        [Header("Aydio Box")]
        [SerializeField] private AudioClip  clipDestroyBox;
        
        [Header("Audio Enemy Slime")]
        
        [SerializeField] private AudioClip slimeTakeDamage;

        [SerializeField] private AudioClip slimeMoving;

        [Header("Player Heling Pick Up")] 
        [SerializeField] private AudioClip healPickUp;


        public void SoungDestroyBox()
        {
            Source.clip = clipDestroyBox;
            Source.Play();
        }

        public void SoungPlayerTakeDamage()
        {
            Source.clip = playerTakeDamage;
            Source.Play();
        }

        public void SoungPlayerIsDead()
        {
            Source.clip = playerDead;
            Source.Play();
            
        }

        public void SoungEnemyMoving()
        {
            Source.clip = slimeMoving;
            Source.Play();
        }

        public void SoungEnemyTakeDamage()
        {
            Source.clip = slimeTakeDamage;
            Source.Play();
        }

        public void UsingHealingPlayer()
        {
            Source.clip = healPickUp;
            Source.Play();
        }
    }
}