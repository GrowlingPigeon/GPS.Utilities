using UnityEngine;

#nullable enable

namespace GrowlingPigeonStudio.Utilities
{
  /// <summary>
  /// GPS Logger.
  /// </summary>
  public static class GPSLogger
  {
    /// <summary>
    /// Logs information.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="data">Data objects.</param>
    public static void LogDebug(string? message, params object?[] data)
    {
#if UNITY_EDITOR
      Debug.Log(string.Format(message, data));
#endif
    }

    /// <summary>
    /// Logs warning.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="data">Data objects.</param>
    public static void LogWarning(string? message, params object?[] data)
    {
#if UNITY_EDITOR
      Debug.LogWarning(string.Format(message, data));
#endif
    }

    /// <summary>
    /// Logs error.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="data">Data objects.</param>
    public static void LogError(string? message, params object?[] data)
    {
#if UNITY_EDITOR
      Debug.LogError(string.Format(message, data));
#endif
    }
  }
}