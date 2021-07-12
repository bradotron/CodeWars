using NUnit.Framework;
using System.Text;

namespace TrainSimulator.Tests
{
  public class Tests
  {
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

    [Test]
    public void CrashBeforeStarted()
    {
      StringBuilder Track = new StringBuilder();
      Track.AppendLine(@"/-----------------\");
      Track.AppendLine(@"|                 |");
      Track.AppendLine(@"|                 |");
      Track.AppendLine(@"|                 |");
      Track.AppendLine(@"|                 |");
      Track.AppendLine(@"\-----------------/");
      /*
      oO|10
      oO|10
      100
      */
    }

    [Test]
    public void CrashCabooser() {
      /* 
/-----------------\
|                 |
|                 |
|                 |
|                 |
\---------S-------/
aA|10
bbbbbB|30
200
*/
    }

    [Test]
    public void CrashChickenRun() {
/*
/-----------------\
|                 |
|                 |
|                 |
|                 |
\-----------------/
aaaA|10
Bbbb|40
100*/
    }

    [Test]
    public void CrashKamikaze() {
/*
/-----------------\
|                 |
|                 |
|                 |
|                 |
\---------S-------/
xX|15
Zzzzzzzzzzzzzz|40
100
*/
    }

    [Test]
    public void CrashMisc() {
/*
/----\     /----\ 
|     \   /     | 
|      \ /      | 
|       S       | 
|      / \      | 
|     /   \     | 
\----/     \----/
Eeeeeeee|32
Xxxx|23
100
*/
    }
    [Test]
    public void CrashSelfDestruct() {
/*
/-------\ 
|       | 
|       | 
\-------+-------------------------------------------------------------------\ 
        |                                                                   |
        |                                                                   |
        \-------------------------------------------------------------------/
aA|10
oooooooooooooooooooooooooO|70
200
*/
    }
    [Test]
    public void CrashTBone() {
/*
/-------\ 
|       | 
|       | 
|       | 
\-------+--------\
        |        |
        |        |
        |        |
        \--------/

aaaA|0
bbbbbbbbbbbbbB|30
100
*/
    }
    [Test]
    public void CrashTBoneAtStation() {
/*
/-------\ 
|       | 
|       | 
|       | 
\-------+--------\
        |        |
        S        |
        |        |
        \--------/

aaaA|22
bbbbB|0
100
*/
    }
    [Test]
    public void Letters() {
/*
/-----------------\
|                 |
|                 |
|                 |
|                 |
\---------S-------/
zZ|10
zzzzzZ|30
200
*/
    }
    [Test]
    public void Limits() {
/*
/-------\ 
|       | 
|       | 
|       | 
\-------+--------\
        |        |
        S        |
        |        |
        \--------/

aaaA|22
bbbbB|0
0
*/
    }
    [Test]
    public void MultiExpress() {
/*
/-----------------\
|                 |
|                 |
|                 |
|                 |
\---------S-------/
xX|10
xxxxxX|30
200
*/
    }
    [Test]
    public void NearMissAtCrossing() {
/*
/-------\ 
|       | 
|       | 
|       | 
\-------+--------\
        |        |
        |        |
        |        |
        \--------/

ooooooO|10
xxxxxxX|27
100
*/
    }
    [Test]
    public void NearMissSelf() {
/*
/-------\ 
|       | 
|       | 
\-------+-------------------------------------------------------------------\ 
        |                                                                   |
        |                                                                   |
        \-------------------------------------------------------------------/
aA|10
oooooooooooooooooooooO|70
200
*/
    }
    [Test]
    public void NoCrash0() {
/*
/-----------------\
|                 |
|                 |
|                 |
|                 |
\-----------------/
aaaaaA|10
bbbbbB|30
100
*/
    }
    [Test]
    public void NoCrash0Tricky() {
/*
/-----\   /-----\   /-----\   /-----\ 
|      \ /       \ /       \ /      | 
|       X         X         X       | 
|      / \       / \       / \      | 
\-----/   \-----/   \-----/   \-----/ 
aaaA|15
bbbB|5
100
*/
    }
    [Test]
    public void NoCrash1() {
/*
/-----------------\
|                 |
|                 |
|                 |
|                 |
\---------S-------/
aaaaaA|10
bbbbbB|30
100
*/
    }
    [Test]
    public void NoCrash2() {
/*
/------S----------\
|                 |
|                 |
|                 |
|                 |
\----------S------/
aaaaaA|10
bbbbbB|30
100
*/
    }
    [Test]
    public void NoCrashCentralStation() {
/*
/-------\ 
|       | 
|       | 
|       | 
\-------S--------\
        |        |
        |        |
        |        |
        \--------/

aaaaaA|10
bbbbbB|20
100
*/
    }
    [Test]
    public void StartExactlyOnTheStation() {
/*
/------S----------\
|                 |
|                 |
|                 |
|                 |
\----------S------/
aaaaaaaaaaaaA|7
xxxX|30
100
*/
    }
    [Test]
    public void TailgateEight() {
/*
/-------\ 
|       | 
|       | 
|       | 
\-------+--------\
        |        |
        |        |
        |        |
        \--------/

aaaA|10
bbbB|14
100
*/
    }
    [Test]
    public void TailgateLoop() {
/*
/-----------------\
|                 |
|                 |
|                 |
|                 |
\-----------------/
aaaA|10
bbbB|14
100
*/
    }
  }
}