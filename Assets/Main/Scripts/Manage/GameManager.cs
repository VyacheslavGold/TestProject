using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]GlobalEventsSystem globalEventsSystem;
    [SerializeField] Camera MainCamera;
    [SerializeField] Camera Camera2;
    [SerializeField]GameObject Player;
    [SerializeField]GameObject CurrentPlayer;
    [SerializeField]Transform Respawn;
    
    void Start()
    {
        Respawn = GetComponent<Transform>();
        //globalEventsSystem = GameObject.FindGameObjectWithTag("GlobalEventSystem").GetComponent<GlobalEventsSystem>();
        globalEventsSystem.Victory.AddListener(Victory);
        globalEventsSystem.GameOver.AddListener(GameOver);
    }

    public void StartGame()
    {
        globalEventsSystem.StartGame.Invoke();
        CurrentPlayer = Instantiate(Player, Respawn.position, Player.GetComponent<Transform>().rotation);
        
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        MainCamera.gameObject.SetActive(true);
        Camera2.gameObject.SetActive(false);
        Debug.Log("Instantiate");
    }
    void Victory()
    {
       Camera2.gameObject.SetActive(true);
        MainCamera.gameObject.SetActive(false);
    }
    public void GameOver()
    {
        
        Camera2.gameObject.SetActive(true);
        MainCamera.gameObject.SetActive(false);
        Destroy(CurrentPlayer);
        
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
