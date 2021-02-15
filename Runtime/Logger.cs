using UnityEngine;

namespace GrowlingPigeonStudio.Utilities
{
  /// <summary>
  /// GPS Logger.
  /// </summary>
  public static class Logger
  {
    /// <summary>
    /// Logs information.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="data">Data objects.</param>
    public static void LogDebug(string message, params object[] data)
    {
#if UNITY_EDITOR
    Debug.Log(string.Concat(string.Format(message, data)));
#endif
    }

    /// <summary>
    /// Logs warning.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="data">Data objects.</param>
    public static void LogWarning(string message, params object[] data)
    {
#if UNITY_EDITOR
    Debug.LogWarning(string.Concat(string.Format(message, data)));
#endif
    }

    /// <summary>
    /// Logs error.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="data">Data objects.</param>
    public static void LogError(string message, params object[] data)
    {
#if UNITY_EDITOR
    Debug.LogError(string.Concat(string.Format(message, data)));
#endif
    }
  }
}