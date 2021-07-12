using NUnit.Framework;
using System.Text;

namespace TrainSimulator.Tests
{
  public class Tests
  {
    [Test]
    public void SmallTrack()
    {
      StringBuilder Track = new StringBuilder();
      Track.AppendLine(@"/------------\");
      Track.AppendLine(@"|            |");
      Track.AppendLine(@"|            |");
      Track.AppendLine(@"\------------/");
      Assert.AreEqual(-1, Dinglemouse.TrainCrash(Track.ToString(), "aA", 5, "bB", 10, 1000));
    }

    [Test]
    public void Test1()
    {
      StringBuilder Track = new StringBuilder();
      Track.AppendLine(@"                                /------------\             ");
      Track.AppendLine(@"/-------------\                /             |             ");
      Track.AppendLine(@"|             |               /              S             ");
      Track.AppendLine(@"|             |              /               |             ");
      Track.AppendLine(@"|        /----+--------------+------\        |             ");
      Track.AppendLine(@"\       /     |              |      |        |             ");
      Track.AppendLine(@" \      |     \              |      |        |             ");
      Track.AppendLine(@" |      |      \-------------+------+--------+---\         ");
      Track.AppendLine(@" |      |                    |      |        |   |         ");
      Track.AppendLine(@" \------+--------------------+------/        /   |         ");
      Track.AppendLine(@"        |                    |              /    |         ");
      Track.AppendLine(@"        \------S-------------+-------------/     |         ");
      Track.AppendLine(@"                             |                   |         ");
      Track.AppendLine(@"/-------------\              |                   |         ");
      Track.AppendLine(@"|             |              |             /-----+----\    ");
      Track.AppendLine(@"|             |              |             |     |     \   ");
      Track.AppendLine(@"\-------------+--------------+-----S-------+-----/      \  ");
      Track.AppendLine(@"              |              |             |             \ ");
      Track.AppendLine(@"              |              |             |             | ");
      Track.AppendLine(@"              |              \-------------+-------------/ ");
      Track.AppendLine(@"              |                            |               ");
      Track.AppendLine(@"              \----------------------------/ ");
      

      Assert.AreEqual(516, Dinglemouse.TrainCrash(Track.ToString(), "Aaaa", 147, "Bbbbbbbbbbb", 288, 1000));
    }
  }
}