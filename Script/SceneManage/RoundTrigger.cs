
using UnityEngine;

namespace Script.SceneManage
{
    public class RoundTrigger : MonoBehaviour
    {
        [SerializeField] private UIManager _uiManager;


        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _uiManager.ActiveCanvaceRoundMenu();
            }
        }
    }
}