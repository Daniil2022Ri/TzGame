

using Script.Particle;
using Script.SoungManager;

using UnityEngine;


namespace Script
{
    public class PlayerHPAndLife : MonoBehaviour
    {
        
        [SerializeField] private SoungGameManager soungGameManager;
        [SerializeField] private ParticleEvent eventParticleEvent;
        [SerializeField] private SettingsPlayer _settingsPlayer;
   
        [SerializeField] [Range(0, 3)] protected  internal float LifePlayer;
        [SerializeField] [Range(0, 60)] private float forceRightDamage;

        [SerializeField] private bool playerIsInvulnerability;
        
      
        
        [Header("Sprite")]
        [SerializeField] private GameObject auraInfinityHP;
       

        [Header("CircleCollider2D")] 
        [SerializeField] private CircleCollider2D player;

        private void Start()
        {
            playerIsInvulnerability = false;
            eventParticleEvent.DiactivadetInfintyHeal();
        }


        private void OnCollisionEnter2D(Collision2D otherCollision )
        {
           if(otherCollision.gameObject.CompareTag("Slime"))
           {
               _takeDamagePlayer();
           }

           if (otherCollision.gameObject.CompareTag("DeadZone"))
           {
               _takeDamagePlayer();
           }
           
        }

        private void OnTriggerEnter2D(Collider2D healPlayerUsing)
        {
           if(healPlayerUsing.gameObject.CompareTag("Healing"))
           {
               eventParticleEvent.PlayerUsingHeling.Play();
               LifePlayer++;
               soungGameManager.UsingHealingPlayer();
           }
        }

        private void _takeDamagePlayer()
        {
            if (playerIsInvulnerability == false)
            {
                playerIsInvulnerability = true;
                auraInfinityHP.SetActive(true);
                eventParticleEvent.ActivatedInfintyHeal();
                soungGameManager.SoungPlayerTakeDamage();
                LifePlayer--;
                _settingsPlayer._rigidbody2D.AddForce(Vector3.up * forceRightDamage, ForceMode2D.Impulse);
                
            }
           if(playerIsInvulnerability == true)
            {
                Invoke("ReturnNormalizeSettingsHealPlayer" , 5f);
            }
        }

        public void ReturnNormalizeSettingsHealPlayer()
        {
            auraInfinityHP.SetActive(false);
            eventParticleEvent.DiactivadetInfintyHeal();
            playerIsInvulnerability = false;
        }
    }
}