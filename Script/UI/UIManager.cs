
using UnityEngine;



public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mineMenu;
    [SerializeField] private GameObject menuNextRound;
    [SerializeField] private GameObject deadMenu;

    private void Start()
    {
        mineMenu.SetActive(false);
        menuNextRound.SetActive(false);
        deadMenu.SetActive(false);
    }

    public void ActiveCanvaceRoundMenu()
    {
        menuNextRound.SetActive(true);
    }

    public void ActiveCanvaceDeadMenu()
    {
        deadMenu.SetActive(true);
    }

    public void ActiveCanvaceMineMenuKey()
    {
        mineMenu.SetActive(true);
    }
}