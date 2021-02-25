using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

namespace GrowlingPigeonStudio.Utilities
{
  /// <summary>
  /// Object pool static class.
  /// </summary>
  public static class ObjectPool
  {
    /// <summary>
    /// Creates object pool builder.
    /// </summary>
    /// <typeparam name="T">Object type.</typeparam>
    /// <returns>Object pool builder.</returns>
    public static ObjectPoolBuilder<T> CreateBuilder<T>()
      where T : class
    {
      return new ObjectPoolBuilder<T>();
    }

    /// <summary>
    /// Generates a defualt object pool.
    /// </summary>
    /// <typeparam name="T">Object type for the pool.</typeparam>
    /// <returns>Default object pool.</returns>
    public static ObjectPool<T> Default<T>()
      where T : class
    {
      return new ObjectPool<T>(null, null, null);
    }
  }
}