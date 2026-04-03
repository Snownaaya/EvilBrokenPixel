using UnityEngine;

public static class GameObjectExtention
{
    public static void Enable(this GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public static void Disable(this GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public static T EnableGameObject<T>(this T component) where T : Component
    {
        component.gameObject.Enable();
        return component;
    }

    public static T DisableGameObject<T>(this T component) where T : Component
    {
        component.gameObject.Disable();
        return component;
    }
}