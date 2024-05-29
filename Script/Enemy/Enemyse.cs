
using Script.Particle;
using Script.SoungManager;

using UnityEngine;

namespace Script.Enemy
{
    public class EnemySlime : MonoBehaviour
    {
        [SerializeField][Range(-1 , 0)] private  float damageEnemySlime;
        [SerializeField] private ParticleEvent particleEvent;
         [SerializeField] private SoungGameManager soungGameManager;

            

            public static void TakeDamageSlime(float HealPlayer)
            {

                HealPlayer--;
            }

       

        private void OnCollisionEnter2D(Collision2D PlayerDetected)
        {
            if (PlayerDetected.gameObject.CompareTag("Player"))
            {
                soungGameManager.SoungPlayerTakeDamage();
                particleEvent.DeadCharacter.Play();
            }
        }
    }
}