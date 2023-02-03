using UnityEngine.Events;

[System.Serializable]
public class GameEventListener
{
    public GameEvent Event;
    public UnityEvent Response;

    public void Register()
    {
        Event.RegisterListener(this);
    }

    public void UnRegister()
    {
        Event.UnRegisterListener(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}

[System.Serializable]
public class GameEventListener<T>
{
    public GameEvent<T> Event;
    public UnityEvent<T> Response;

    public void Register()
    {
        Event.RegisterListener(this);
    }

    public void UnRegister()
    {
        Event.UnRegisterListener(this);
    }

    public void OnEventRaised(T argument)
    {
        Response.Invoke(argument);
    }
}
