using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] GlobalEventsSystem globalEventsSystem;
    [SerializeField] GameObject Panel;
    [SerializeField] TextMeshProUGUI PanelText;

        void Start()
        {
            Panel = GameObject.FindGameObjectWithTag("MainPanel");
            PanelText = GameObject.FindGameObjectWithTag("MainText").GetComponent<TextMeshProUGUI>();
           globalEventsSystem = GameObject.FindGameObjectWithTag("GlobalEventSystem").GetComponent<GlobalEventsSystem>();
            globalEventsSystem.Victory.AddListener(VictoryUI);
            globalEventsSystem.StartGame.AddListener(StartGame);
            globalEventsSystem.GameOver.AddListener(GameOverUI);
        }
    public void VictoryUI()
    {
        Panel.SetActive(true);
        PanelText.text = "Victory!"; 
    }
    public void GameOverUI()
    {
        Panel.SetActive(true);
        PanelText.text = "GameOver";
    }
    public void StartGame()
    {
        Panel.SetActive(false);
    }
    
}
