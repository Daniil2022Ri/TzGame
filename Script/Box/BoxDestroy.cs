
using Script;
using Script.SoungManager;

using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    [SerializeField] private SettingsPlayer player;
    [SerializeField] private BoxDestroy box;
    [SerializeField] private SoungGameManager soungGameManager;
    [SerializeField] private ParticleSystem destractionParticle;

    private void Start()
    {
        destractionParticle.transform.position = box.transform.position;
        destractionParticle.Stop();
    }

    private void DestroyBox()
    {
        destractionParticle.Play();
        soungGameManager.SoungDestroyBox();
        Destroy(gameObject , 0.5f);
        
    }

    private void OnTriggerEnter2D(Collider2D PlayerHead)
    {
        if (PlayerHead.gameObject.CompareTag("Player"))
        {
            DestroyBox();
            
        }
    }
}
