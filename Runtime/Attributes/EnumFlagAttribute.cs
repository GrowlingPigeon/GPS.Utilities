using System;
using UnityEngine;

namespace GrowlingPigeonStudio.Utilities
{
  /// <summary>
  /// Allows enums to be used as flags in the Unity Inspector.
  /// Note, targeted enum MUST be decorated by <see cref="FlagsAttribute"/>.
  /// </summary>
  public class EnumFlagAttribute
    : PropertyAttribute
  {
    /// <summary>
    /// Name of property.
    /// </summary>
    public string name;

    /// <summary>
    /// Initializes a new instance of the <see cref="EnumFlagAttribute"/> class.
    /// </summary>
    public EnumFlagAttribute()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EnumFlagAttribute"/> class.
    /// </summary>
    /// <param name="name">Name to set.</param>
    public EnumFlagAttribute(string name)
    {
      this.name = name;
    }
  }
}