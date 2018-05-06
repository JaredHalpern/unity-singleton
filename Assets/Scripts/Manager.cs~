using UnityEngine;

public class Manager<T> : MonoBehaviour where T : Manager<T> // generics
{
    private static T _sharedInstance = null;

    // property
    public static T sharedInstance
    {
        get
        {
            if (_sharedInstance == null)
            {
                GameObject gameObj = new GameObject();
                _sharedInstance = gameObj.AddComponent<T>();
                gameObj.name = typeof(T).ToString() + "Singleton";
                print("Created " + gameObj.name);
            }
            else
            {
                print("Destroyed " + _sharedInstance.name);
                Destroy(_sharedInstance.gameObject);
                DestroyImmediate(_sharedInstance);
            }
            return _sharedInstance;
        }
    }

    public virtual void Awake()
    {
        DontDestroyOnLoad(_sharedInstance);
    }
}