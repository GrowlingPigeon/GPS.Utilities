using System;
using UnityEditor;
using UnityEngine;

namespace GrowlingPigeonStudio.Utilities
{
  /// <summary>
  /// Enum flag drawer.
  /// </summary>
  [CustomPropertyDrawer(typeof(EnumFlagAttribute))]
  public class EnumFlagDrawer
    : PropertyDrawer
  {
    /// <summary>
    /// Called when GUI is refreshed.
    /// </summary>
    /// <param name="position">Position.</param>
    /// <param name="property">Property.</param>
    /// <param name="label">Label.</param>
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
      // this code was taken from http://dotsquid.com/2017/04/05/enum-flag-attribute-plus-property-drawer/
      var enumFlagAttribute = (EnumFlagAttribute)this.attribute;
      var targetEnum = (Enum)this.fieldInfo.GetValue(property.serializedObject.targetObject);

      string propName = enumFlagAttribute.name;
      if (string.IsNullOrEmpty(propName))
      {
        propName = ObjectNames.NicifyVariableName(property.name);
      }

      EditorGUI.BeginProperty(position, label, property);
      Enum enumNew = EditorGUI.EnumFlagsField(position, propName, targetEnum);
      property.intValue = (int)Convert.ChangeType(enumNew, targetEnum.GetType());
      EditorGUI.EndProperty();
    }
  }
}