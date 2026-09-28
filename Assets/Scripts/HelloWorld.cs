using UnityEngine;

public class HelloWorld : MonoBehaviour
{   
    [Header("Player Settings")]
    [Tooltip("Enter the player's name here")]
    [SerializeField] private string PlayerName;
    [Tooltip("Enter the score of the player here")]
    [Range(0, 100)]
    [SerializeField] private int PlayerScore;
    [HideInInspector] public bool isPlayer;

    void Start()
    {
        Debug.Log("Hello " + PlayerName);
    }

    void Update()
    {
        
    }
}
