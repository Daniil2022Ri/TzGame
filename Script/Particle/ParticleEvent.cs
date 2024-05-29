using UnityEngine;

namespace Script.Particle
{
    public class ParticleEvent : MovingPlayer
    {
        public ParticleSystem PlayerUsingHeling;

        public ParticleSystem DeadCharacter;

        public ParticleSystem MovingPlayer;
        
        public ParticleSystem JumpPlayer;

        public ParticleSystem PlayerInfinityHP;


        public void UsingParticleForMoving()
        {
                MovingPlayer.Play();
        }

        public void ActivatedInfintyHeal()
        {
            PlayerInfinityHP.Play();
        }

        public void DiactivadetInfintyHeal()
        {
            PlayerInfinityHP.Stop();
        }

    }
}