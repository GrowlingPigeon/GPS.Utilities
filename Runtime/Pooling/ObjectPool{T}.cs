using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

namespace GrowlingPigeonStudio.Utilities
{
  /// <summary>
  /// Object pooler.
  /// </summary>
  /// <typeparam name="T">Object type to pool.</typeparam>
  public class ObjectPool<T>
    where T : class
  {
    /// <summary>
    /// Stack of objects. Stack is just as good as List but makes adding and removing easier to code and maintain.
    /// </summary>
    private readonly Stack<T> objects = new Stack<T>();

    /// <summary>
    /// Generator callback. Performs generation of object if object pool is empty.
    /// </summary>
    private readonly Func<T>? generateCallback;

    /// <summary>
    /// Get callback. Performs actions on objects that are taken from the object pool.
    /// </summary>
    private readonly Action<T>? getCallback;

    /// <summary>
    /// Recycle callback. Performs actions on objects that are recycled back to the object pool.
    /// </summary>
    private readonly Action<T>? recycleCallback;

    /// <summary>
    /// Gets total number of objects generated by this object pool.
    /// </summary>
    public int TotalGenerated { get; private set; } = 0;

    /// <summary>
    /// Gets number of objects currently in the pool.
    /// </summary>
    public int Count => this.objects.Count;

    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectPool{T}"/> class.
    /// </summary>
    /// <param name="generateCallback">Generator callback.</param>
    /// <param name="getCallback">Get callback.</param>
    /// <param name="recycleCallback">Recycle callback.</param>
    public ObjectPool(Func<T>? generateCallback, Action<T>? getCallback, Action<T>? recycleCallback)
    {
      this.generateCallback = generateCallback;
      this.getCallback = getCallback;
      this.recycleCallback = recycleCallback;
    }

    /// <summary>
    /// Recycles object.
    /// </summary>
    /// <param name="entry">Entry to recycle.</param>
    public void Recycle(T? entry)
    {
      if (entry is null)
      {
        return;
      }

      this.PerformRecycleCallback(entry);
      this.objects.Push(entry);
    }

    /// <summary>
    /// Gets or creates object.
    /// </summary>
    /// <returns>Object found or created.</returns>
    public T? GetOrCreate()
    {
      var obj = this.GetOrCreateHelper();
      this.PerformGetCallback(obj);
      return obj;
    }

    /// <summary>
    /// Performs recycle callback on object.
    /// </summary>
    /// <param name="obj">Object instance to perform callback on.</param>
    private void PerformRecycleCallback(T obj)
    {
      if (this.recycleCallback is null)
      {
        return;
      }

      this.recycleCallback(obj);
    }

    /// <summary>
    /// Performs get callback on object before sending it back to the caller.
    /// </summary>
    /// <param name="obj">Object instance to perform callback on.</param>
    private void PerformGetCallback(T? obj)
    {
      if (this.getCallback is null)
      {
        return;
      }

      if (obj is null)
      {
        return;
      }

      this.getCallback(obj);
    }

    /// <summary>
    /// Get or create helper.
    /// </summary>
    /// <returns>Obtained instance or null.</returns>
    private T? GetOrCreateHelper()
    {
      if (this.Count > 0)
      {
        return this.objects.Pop();
      }

      if (this.generateCallback is null)
      {
        return null;
      }

      var obj = this.generateCallback();
      if (obj is { })
      {
        this.TotalGenerated++;
      }

      return obj;
    }
  }
}