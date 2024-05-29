using UnityEngine;


namespace Script
{
    public class SettingsPlayer : MonoBehaviour
    {
        [SerializeField] public Rigidbody2D _rigidbody2D;

        [Header("Settings Speed ,Jump and Heal Player")] [SerializeField] [Range(0, 4)]
        private float moveSpeedPlayer;

        [SerializeField] private Animator _animator;

        [SerializeField] [Range(1, 5)] private float strongPlayerJump;
        

        [Header("Collision detected ")] [SerializeField]
        private Collision2D _detectedBodyPlayer;

        [SerializeField] private Collision2D _detectedDedZoneLeght;

        [Header("Cheking Ground")] [SerializeField]
        private bool isGrounded;

        [SerializeField] private float groundCheckDistance = 0.1f;
        [SerializeField] private Transform groundCheckPoint;

        [Header("Rotation Player Settings")] [SerializeField] [Min(0.0f)]
        private float turnSmoothTime = 0.1f;

        private Vector2 _movingPlayer;

        private float _horizontal;

    

        private float turnSmoothVelocity;

        private void Start()
        {
            _rigidbody2D.GetComponent<Rigidbody2D>();
        }




        public void MovingPlayerandJump()
        {
            float _horizontal = Input.GetAxis("Horizontal") * moveSpeedPlayer;
            
            _animator.SetFloat("HorizontalInput" ,_horizontal);

            _rigidbody2D.velocity = new Vector2(_horizontal * moveSpeedPlayer, _rigidbody2D.velocity.y);

            isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckDistance,

                LayerMask.GetMask("Ground"));

            if (isGrounded && Input.GetButton("Jump"))
            {

                _rigidbody2D.AddForce(Vector2.up * strongPlayerJump, ForceMode2D.Impulse);
            }

        }

        public void RotatePlayerMoving()
        {
            _horizontal = Input.GetAxisRaw("Horizontal");
           


            if (_horizontal != 0 || _horizontal != 0)
            {

                float targetAngle = Mathf.Atan2(_horizontal, _horizontal) * Mathf.Rad2Deg;

                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.z, targetAngle, ref turnSmoothVelocity,
                    turnSmoothTime);

                transform.rotation = Quaternion.Euler(0f, angle,0f );


                transform.localScale = new Vector3(Mathf.Sign(_horizontal), 1, 1);
            }

        }
    }
}
