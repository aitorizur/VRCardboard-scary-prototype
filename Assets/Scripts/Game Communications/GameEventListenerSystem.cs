using UnityEngine;

public class GameEventListenerSystem : MonoBehaviour
{
    [SerializeField] public GameEventListener[] gameEventListeners = new GameEventListener[1];

    private void OnEnable()
    {
        RegisterAllListeners();
    }

    private void OnDisable()
    {
        UnRegisterAllListeners();
    }

    public void RegisterAllListeners()
    {
        foreach (GameEventListener currentGameEventListener in gameEventListeners)
        {
            currentGameEventListener.Register();
        }
    }

    public void UnRegisterAllListeners()
    {
        foreach (GameEventListener currentGameEventListener in gameEventListeners)
        {
            currentGameEventListener.UnRegister();
        }
    }
}

public class GameEventListenerSystem<T> : MonoBehaviour
{
    [SerializeField] public GameEventListener<T>[] gameEventListeners = new GameEventListener<T>[1];

    private void OnEnable()
    {
        RegisterAllListeners();
    }

    private void OnDisable()
    {
        UnRegisterAllListeners();
    }

    public void RegisterAllListeners()
    {
        foreach (GameEventListener<T> currentGameEventListener in gameEventListeners)
        {
            currentGameEventListener.Register();
        }
    }

    public void UnRegisterAllListeners()
    {
        foreach (GameEventListener<T> currentGameEventListener in gameEventListeners)
        {
            currentGameEventListener.UnRegister();
        }
    }
}