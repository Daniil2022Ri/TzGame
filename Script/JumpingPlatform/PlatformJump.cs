

using Script;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;


public class PlatformJump : MonoBehaviour
{
    [SerializeField] private SettingsPlayer jumpplayer;
    [SerializeField] private PlatformJump platfrom;

    [SerializeField][Range(1,300)] private float strongJump;

    

    private void JumpingPlayer()
    {
        jumpplayer._rigidbody2D.velocity = new Vector2(0, jumpplayer._rigidbody2D.velocity.y);
        jumpplayer._rigidbody2D.AddForce(Vector2.up * strongJump , ForceMode2D.Impulse);
        
    }

    private void OnCollisionEnter2D(Collision2D playerCollision)
    {
        if (playerCollision.gameObject.CompareTag("Player"))
        {
            JumpingPlayer();
        }
        else
        {
            return;
        }
    }
}
