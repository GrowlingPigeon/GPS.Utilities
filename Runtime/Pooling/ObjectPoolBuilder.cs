using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

namespace GrowlingPigeonStudio.Utilities
{
  /// <summary>
  /// Object pool builder for object pools with reference objects of type T.
  /// </summary>
  /// <typeparam name="T">Object type.</typeparam>
  public class ObjectPoolBuilder<T>
    where T : class
  {
    /// <summary>
    /// Generate callback.
    /// </summary>
    private Func<T?>? generateCallback = null;

    /// <summary>
    /// Recycle callback.
    /// </summary>
    private Action<T>? recycleCallback = null;

    /// <summary>
    /// Get callback.
    /// </summary>
    private Action<T>? getCallback = null;

    /// <summary>
    /// Adds a generator callback and replaces any callback that might already currently be there.
    /// </summary>
    /// <param name="callback">Callback.</param>
    /// <returns>Builder.</returns>
    public ObjectPoolBuilder<T> AddGeneratorCallback(Func<T?>? callback)
    {
      this.generateCallback = callback;
      return this;
    }

    /// <summary>
    /// Adds a recycle callback and replaces any callback that might already currently be there.
    /// </summary>
    /// <param name="callback">Callback.</param>
    /// <returns>Builder.</returns>
    public ObjectPoolBuilder<T> AddRecycleCallback(Action<T>? callback)
    {
      this.recycleCallback = callback;
      return this;
    }

    /// <summary>
    /// Adds a get callback and replaces any callback that might already currently be there.
    /// </summary>
    /// <param name="callback">Callback.</param>
    /// <returns>Builder.</returns>
    public ObjectPoolBuilder<T> AddGetCallback(Action<T>? callback)
    {
      this.getCallback = callback;
      return this;
    }

    /// <summary>
    /// Builds the object pool with given callback(s).
    /// </summary>
    /// <returns>Object pool.</returns>
    public ObjectPool<T> Build()
    {
      return new ObjectPool<T>(this.generateCallback, this.getCallback, this.recycleCallback);
    }
  }
}