#nullable enable

namespace GrowlingPigeonStudio.Utilities
{
  /// <summary>
  /// GPS event.
  /// </summary>
  public delegate void GPSEvent();

  /// <summary>
  /// GPS event with one argument.
  /// </summary>
  /// <typeparam name="T0">Type 0.</typeparam>
  public delegate void GPSEvent<T0>(T0 arg0);

  /// <summary>
  /// GPS event with two arguments.
  /// </summary>
  /// <typeparam name="T0">Type 0.</typeparam>
  /// <typeparam name="T1">Type 1.</typeparam>
  public delegate void GPSEvent<T0, T1>(T0 arg0, T1 arg1);

  /// <summary>
  /// GPS event with three arguments.
  /// </summary>
  /// <typeparam name="T0">Type 0.</typeparam>
  /// <typeparam name="T1">Type 1.</typeparam>
  /// <typeparam name="T2">Type 2.</typeparam>
  public delegate void GPSEvent<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2);

  /// <summary>
  /// GPS event with four arguments.
  /// </summary>
  /// <typeparam name="T0">Type 0.</typeparam>
  /// <typeparam name="T1">Type 1.</typeparam>
  /// <typeparam name="T2">Type 2.</typeparam>
  /// <typeparam name="T3">Type 3.</typeparam>
  public delegate void GPSEvent<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3);

  /// <summary>
  /// GPS event with five arguments.
  /// </summary>
  /// <typeparam name="T0">Type 0.</typeparam>
  /// <typeparam name="T1">Type 1.</typeparam>
  /// <typeparam name="T2">Type 2.</typeparam>
  /// <typeparam name="T3">Type 3.</typeparam>
  /// <typeparam name="T4">Type 4.</typeparam>
  public delegate void GPSEvent<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
}