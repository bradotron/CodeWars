namespace AngleMath;
public class AngleMath
{
  public static float AngleClamp360(float angle)
  {
    if (angle > 360f)
    {
      return angle % 360f;
    }

    if (angle < 0f)
    {
      return 360f + (angle % 360f);
    }

    return angle;
  }
}
