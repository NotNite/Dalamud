using System;

namespace Dalamud.Utility;

/// <summary>
/// Helpers for working with thread safety.
/// </summary>
public static class ThreadSafety
{
    [ThreadStatic]
    private static bool isMainThread;

    /// <summary>
    /// Gets a value indicating whether the current thread is the main thread.
    /// </summary>
    public static bool IsMainThread => isMainThread;

    /// <summary>
    /// Throws an exception when the current thread is not the main thread.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the current thread is not the main thread.</exception>
    public static void AssertMainThread()
    {
        if (!isMainThread)
        {
            throw new InvalidOperationException("Not on main thread!");
        }
    }

    /// <summary>
    /// Throws an exception when the current thread is the main thread.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the current thread is the main thread.</exception>
    public static void AssertNotMainThread()
    {
        if (isMainThread)
        {
            throw new InvalidOperationException("On main thread!");
        }
    }

    /// <summary>
    /// Marks a thread as the main thread.
    /// </summary>
    internal static void MarkMainThread()
    {
        isMainThread = true;
    }
}
