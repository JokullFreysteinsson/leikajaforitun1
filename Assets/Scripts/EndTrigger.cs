using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameMangaer gameMangaer;

    void OnTriggerEnter ()
    {
        gameMangaer.CompleteLevel();
    }
}
