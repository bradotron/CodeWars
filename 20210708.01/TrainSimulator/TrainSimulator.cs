using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainSimulator
{
  public class Dinglemouse
  {
    static void Main(string[] args)
    {
      StringBuilder Track = new StringBuilder();
      int result = 0;
      Console.Clear();

      // Console.WriteLine("Example");

      // Track.AppendLine(@"                                /------------\             ");
      // Track.AppendLine(@"/-------------\                /             |             ");
      // Track.AppendLine(@"|             |               /              S             ");
      // Track.AppendLine(@"|             |              /               |             ");
      // Track.AppendLine(@"|        /----+--------------+------\        |             ");
      // Track.AppendLine(@"\       /     |              |      |        |             ");
      // Track.AppendLine(@" \      |     \              |      |        |             ");
      // Track.AppendLine(@" |      |      \-------------+------+--------+---\         ");
      // Track.AppendLine(@" |      |                    |      |        |   |         ");
      // Track.AppendLine(@" \------+--------------------+------/        /   |         ");
      // Track.AppendLine(@"        |                    |              /    |         ");
      // Track.AppendLine(@"        \------S-------------+-------------/     |         ");
      // Track.AppendLine(@"                             |                   |         ");
      // Track.AppendLine(@"/-------------\              |                   |         ");
      // Track.AppendLine(@"|             |              |             /-----+----\    ");
      // Track.AppendLine(@"|             |              |             |     |     \   ");
      // Track.AppendLine(@"\-------------+--------------+-----S-------+-----/      \  ");
      // Track.AppendLine(@"              |              |             |             \ ");
      // Track.AppendLine(@"              |              |             |             | ");
      // Track.AppendLine(@"              |              \-------------+-------------/ ");
      // Track.AppendLine(@"              |                            |               ");
      // Track.AppendLine(@"              \----------------------------/ ");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "Aaaa", 147, "Bbbbbbbbbbb", 288, 1000);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("CrashBeforeStarted");

      // Track.Clear();
      // Track.AppendLine(@"/-----------------\");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.Append(    @"\-----------------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "oO", 10, "oO", 10, 100);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("CrashCabooser");

      // Track.Clear();
      // Track.AppendLine(@"/-----------------\");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.Append(    @"\---------S-------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "aA", 10, "bbbbbB", 30, 200);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("CrashChickenRun");

      // Track.Clear();
      // Track.AppendLine(@"/-----------------\");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.Append(    @"\-----------------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "aaaA", 10, "Bbbb", 40, 100);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("CrashKamikaze");

      // Track.Clear();
      // Track.AppendLine(@"/-----------------\");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.Append(    @"\---------S-------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "xX", 10, "Zzzzzzzzzzzzzz", 40, 100);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("CrashMisc");

      // Track.Clear();
      // Track.AppendLine(@"/----\     /----\");
      // Track.AppendLine(@"|     \   /     |");
      // Track.AppendLine(@"|      \ /      |");
      // Track.AppendLine(@"|       S       |");
      // Track.AppendLine(@"|      / \      |");
      // Track.AppendLine(@"|     /   \     |");
      // Track.Append(@"\----/     \----/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "Eeeeeeee", 32, "Xxxx", 23, 100);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("CrashSelfDestruct");

      // Track.Clear();
      // Track.AppendLine(@"/-------\");
      // Track.AppendLine(@"|       | ");
      // Track.AppendLine(@"|       | ");
      // Track.AppendLine(@"\-------+-------------------------------------------------------------------\");
      // Track.AppendLine(@"        |                                                                   |");
      // Track.AppendLine(@"        |                                                                   |");
      // Track.AppendLine(@"        \-------------------------------------------------------------------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "aA", 10, "oooooooooooooooooooooooooO", 70, 200);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("CrashTBone");

      // Track.Clear();
      // Track.AppendLine(@"/-------\");
      // Track.AppendLine(@"|       | ");
      // Track.AppendLine(@"|       | ");
      // Track.AppendLine(@"\-------+--------\");
      // Track.AppendLine(@"        |        |");
      // Track.AppendLine(@"        |        |");
      // Track.AppendLine(@"        \--------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "aaaA", 0, "bbbbbbbbbbbbbB", 30, 100);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("Letters");

      // Track.Clear();
      // Track.AppendLine(@"/-----------------\");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.Append(    @"\---------S-------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "zZ", 10, "zzzzzZ", 30, 200);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      // Console.WriteLine("Limits");

      // Track.Clear();
      // Track.AppendLine(@"/-------\");
      // Track.AppendLine(@"|       | ");
      // Track.AppendLine(@"|       | ");
      // Track.AppendLine(@"\-------+--------\");
      // Track.AppendLine(@"        |        |");
      // Track.AppendLine(@"        |        |");
      // Track.AppendLine(@"        \--------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "aaaA", 22, "bbbbB", 0, 0);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      Console.WriteLine("NoCrash0Tricky");

      Track.Clear();
      Track.AppendLine(@"/-----\   /-----\   /-----\   /-----\ ");
      Track.AppendLine(@"|      \ /       \ /       \ /      | ");
      Track.AppendLine(@"|       X         X         X       | ");
      Track.AppendLine(@"|      / \       / \       / \      | ");
      Track.AppendLine(@"\-----/   \-----/   \-----/   \-----/ ");


      result = Dinglemouse.TrainCrash(Track.ToString(), "aaaA", 15, "bbbB", 5, 100);
      Console.WriteLine("Result: " + result.ToString());
      Console.ReadKey();
      Console.Clear();

      // Console.WriteLine("NoCrash1");

      // Track.Clear();
      // Track.AppendLine(@"/-----------------\");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.AppendLine(@"|                 |");
      // Track.Append(    @"\---------S-------/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "aaaaaA", 10, "bbbbbB", 30, 100);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      Console.WriteLine("NoCrashCentralStation");

      Track.Clear();
      Track.AppendLine(@"/-------\");
      Track.AppendLine(@"|       | ");
      Track.AppendLine(@"|       | ");
      Track.AppendLine(@"\-------S--------\");
      Track.AppendLine(@"        |        |");
      Track.AppendLine(@"        |        |");
      Track.AppendLine(@"        \--------/");

      result = Dinglemouse.TrainCrash(Track.ToString(), "aaaaaA", 10, "bbbbbB", 20, 100);
      Console.WriteLine("Result: " + result.ToString());
      Console.ReadKey();
      Console.Clear();

      // Console.WriteLine("CrashMisc");

      // Track.Clear();
      // Track.AppendLine(@"/---\");
      // Track.AppendLine(@"|   | ");
      // Track.AppendLine(@"\--\| ");
      // Track.AppendLine(@"   || ");
      // Track.AppendLine(@"   |\------\ ");
      // Track.AppendLine(@"   |/----\ | ");
      // Track.AppendLine(@"   ||    | | ");
      // Track.AppendLine(@"/--/|    | | ");
      // Track.AppendLine(@"|   |    | | ");
      // Track.AppendLine(@"\---/    \-/");

      // result = Dinglemouse.TrainCrash(Track.ToString(), "aaaaaA", 10, "bbbbbB", 20, 100);
      // Console.WriteLine("Result: " + result.ToString());
      // Console.ReadKey();
      // Console.Clear();

      Console.WriteLine("CrashMisc");

      Track.Clear();
      Track.AppendLine(@"    /---------------------\               /-\ /-\  ");
      Track.AppendLine(@"   //---------------------\\              | | | |  ");
      Track.AppendLine(@"  //  /-------------------\\\             | / | /  ");
      Track.AppendLine(@"  ||  |/------------------\\\\            |/  |/   ");
      Track.AppendLine(@"  ||  ||                   \\\\           ||  ||   ");
      Track.AppendLine(@"  \\  ||                   | \\\          ||  ||   ");
      Track.AppendLine(@"   \\-//                   | || \---------/\--/|   ");
      Track.AppendLine(@"/-\ \-/                    \-/|                |   ");
      Track.AppendLine(@"|  \--------------------------/                |   ");
      Track.AppendLine(@"\----------------------------------------------/   ");

      result = Dinglemouse.TrainCrash(Track.ToString(), "aaaaaA", 10, "bbbbbB", 20, 100);
      Console.WriteLine("Result: " + result.ToString());
      Console.ReadKey();
      Console.Clear();

      /*
/---\ 
|   |  
\--\| 
   ||  
   |\------\  
   |/----\ |   
   ||    | |    
/--/|    | |    
|   |    | |    
\---/    \-/
Eee|33
aaA|2
100

    /---------------------\               /-\ /-\  
   //---------------------\\              | | | |  
  //  /Xxxxxxxxxxxxxxxxxxx\\\             | / | /  
  ||  |/------------------\\\\            |/  |/   
  ||  ||                   \\\\           ||  ||   
  \\  ||                   | \\\          ||  ||   
   \\-//                   | || \---------/\--/|   
/-\ \-/                    \-/|                |   
|  \--------------------------/                |   
\-xxxxxxxxxX-----------------------------------/   

Xxxxxxxxxxxxxxxxxxx|192
Xxxxxxxxxx|108

      */
    }

    // =======================================
    // Blaine is a pain, and that is the truth
    // =======================================

    public static int TrainCrash(string track, string aTrain, int aTrainPos, string bTrain, int bTrainPos, int limit)
    {
      Track TrainTrack = new Track(track);

      TrainTrack.AddTrain(new Track.Train(aTrain, aTrainPos, TrainTrack.Length));
      TrainTrack.AddTrain(new Track.Train(bTrain, bTrainPos, TrainTrack.Length));

      if (TrainTrack.IsCollision)
      {
        return 0;
      }

      int time = 0;

      while (!TrainTrack.IsCollision && time < limit)
      {
        TrainTrack.IncrementTime();

        time++;
      }

      return TrainTrack.IsCollision ? time : -1;
    }

    public class Track
    {
      private string[] OriginalStringArray;
      private string track;
      private List<TrackPiece> TrackPieces;
      private List<TrackPiece> Intersections;

      public int Length
      {
        get
        {
          return TrackPieces.Count;
        }
      }
      private List<Train> Trains;

      public bool IsCollision
      {
        get
        {
          List<int> TrainPositions = new List<int>();

          foreach (Train train in Trains)
          {
            if (TrainPositions.Any(position => train.TrackPositions.Contains(position)))
            {
              return true;
            }
            else
            {
              foreach (int position in train.TrackPositions)
              {
                if (TrainPositions.Contains(position))
                {
                  return true;
                }

                TrackPiece intersection = Intersections.FirstOrDefault(i => i.Position == position);

                if (intersection != null)
                {
                  TrainPositions
                    .AddRange(Intersections.Where(i => intersection.x == i.x && intersection.y == i.y)
                    .Select(i => i.Position)
                    .ToList());
                }
                else
                {
                  TrainPositions.Add(position);
                }
              }
            }
          }
          return false;
        }
      }

      public void IncrementTime()
      {
        foreach (Train train in Trains)
        {
          if (train.Letter != 'x' && train.AtStation == true)
          {
            if (train.StationTimer < train.Length - 1)
            {
              train.StationTimer++;
            }
            else
            {
              train.StationTimer = 0;
              train.AtStation = false;
            }
          }

          if (!train.AtStation)
          {
            train.Position = train.Position + train.Direction;

            if (train.Position < 0)
            {
              train.Position = (TrackPieces.Count) + train.Position;
            }
            if (train.Position >= TrackPieces.Count)
            {
              train.Position = train.Position - TrackPieces.Count;
            }
          }

          if (TrackPieces[train.Position].Piece == 'S' && train.Letter != 'x')
          {
            train.AtStation = true;
          }
        }
      }

      public Track(string track)
      {
        OriginalStringArray = track.Split(System.Environment.NewLine);

        if (OriginalStringArray[OriginalStringArray.Length - 1].Length <= 1)
        {
          OriginalStringArray = OriginalStringArray.SkipLast(1).ToArray();
        }

        int xDimension = OriginalStringArray.Select(s => s.Length).Max();
        int yDimension = OriginalStringArray.Length;

        for (int i = 0; i < OriginalStringArray.Length; i++)
        {
          if (OriginalStringArray[i].Length < xDimension)
          {
            OriginalStringArray[i] = OriginalStringArray[i].PadRight(xDimension);
          }
        }

        GenerateTrackPieces(OriginalStringArray);

        Trains = new List<Train>();
      }

      public void AddTrain(Train train)
      {
        Trains.Add(train);
      }

      private void GenerateTrackPieces(string[] tracks)
      {
        TrackPieces = new List<TrackPiece>();
        Intersections = new List<TrackPiece>();
        char[] ValidTrackPieces = new char[] { '-', '|', '/', '\\', '+', 'X', 'S' };
        int StartXPos = tracks[0].IndexOfAny(ValidTrackPieces);
        int StartYPos = 0;

        char Current = tracks[StartYPos][StartXPos];
        TrackPieces.Add(new TrackPiece(Current, 0, StartXPos, StartYPos));

        int xDot = Current == '|' ? 0 : 1;
        int yDot = Current == '-' || Current == 'S' || Current == '/' ? 0 : 1;

        int xPos = StartXPos + xDot;
        int yPos = StartYPos + yDot;

        char Previous = Current;

        bool done = false;

        while (!done)
        {

          Previous = Current;
          Current = tracks[yPos][xPos];
          TrackPieces.Add(new TrackPiece(Current, TrackPieces.Count - 1, xPos, yPos));

          if (Current == '+' || Current == 'X' || Current == 'S')
          {
            Intersections.Add(new TrackPiece(Current, TrackPieces.Count - 1, xPos, yPos));
          }

          // find the xDot and yDot
          switch (Current)
          {
            case '|':
              xDot = 0;
              // yDot stays the same; 
              break;

            case '-':
              // xDot stays the same
              yDot = 0;
              break;

            case '/':
              if (Previous == '-')
              {
                yDot = -xDot;
                if (xDot < 0)
                {
                  xDot = tracks[yPos + 1][xPos] != ' ' ? 0 : -1;
                }
                else
                {
                  xDot = tracks[yPos - 1][xPos] != ' ' ? 0 : 1;
                }
              }
              else if (Previous == '|' || Previous == '/' || Previous == '+')
              {
                if (yDot > 0)
                {
                  if (tracks[yPos][xPos - 1] == '-')
                  {
                    xDot = -1;
                    yDot = 0;
                  }
                  else if (yPos + 1 < tracks.Length)
                  {
                    if (tracks[yPos + 1][xPos - 1] == '/' || tracks[yPos + 1][xPos - 1] == 'X')
                    {
                      xDot = -1;
                      yDot = 1;
                    }
                    if (tracks[yPos + 1][xPos] == '|')
                    {
                      xDot = 0;
                      yDot = 1;
                    }
                  }
                }
                else
                {
                  if (tracks[yPos][xPos + 1] == '-')
                  {
                    xDot = 1;
                    yDot = 0;
                  }
                  else if (yPos - 1 >= 0 && tracks[yPos - 1][xPos + 1] == '/' || tracks[yPos - 1][xPos + 1] == 'X')
                  {
                    xDot = 1;
                    yDot = -1;
                  }
                  else if (yPos - 1 >= 0 && tracks[yPos - 1][xPos] == '|')
                  {
                    xDot = 0;
                    yDot = -1;
                  }
                }
              }
              else
              {
                // something
              }
              break;
            case '\\':
              if (Previous == '-')
              {
                if (xDot > 0)
                {
                  if (xPos + 1 < tracks[yPos].Length)
                  {
                    if (tracks[yPos + 1][xPos + 1] == '\\')
                    {
                      xDot = 1;
                      yDot = 1;
                    }
                  }
                  if (tracks[yPos + 1][xPos] == '|')
                  {
                    xDot = 0;
                    yDot = 1;
                  }
                }
                else
                {
                  if (xPos - 1 > 0)
                  {
                    if (tracks[yPos - 1][xPos - 1] == '\\')
                    {
                      xDot = -1;
                      yDot = -1;
                    }
                  }
                  if (tracks[yPos - 1][xPos] == '|')
                  {
                    xDot = 0;
                    yDot = -1;
                  }
                }
              }
              else if (Previous == '|' || Previous == '\\')
              {
                if (yDot < 0)
                {
                  if (yPos - 1 >= 0)
                  {
                    if (tracks[yPos - 1][xPos] == '|')
                    {
                      xDot = 0;
                      yDot = -1;
                    }
                    else if (xPos - 1 >= 0 && tracks[yPos - 1][xPos - 1] == '\\' || tracks[yPos - 1][xPos - 1] == 'X')
                    {
                      xDot = -1;
                      yDot = -1;
                    }
                    else
                    {
                      xDot = -1;
                      yDot = 0;
                    }
                  }
                  else
                  {
                    yDot = 0;
                    xDot = -1;
                  }
                }
                else
                {
                  if (yPos + 1 < tracks.Length)
                  {
                    if (tracks[yPos + 1][xPos] == '|')
                    {
                      yDot = 1;
                      xDot = 0;
                    }
                    if (tracks[yPos + 1][xPos + 1] == '\\' || tracks[yPos - 1][xPos - 1] == 'X')
                    {
                      yDot = 1;
                      xDot = 1;
                    }
                  }

                  if (tracks[yPos][xPos + 1] == '-')
                  {
                    yDot = 0;
                    xDot = 1;
                  }
                }
              }
              else
              {
                // something
              }
              break;
            case '+':
            case 'X':
            case 'S':
              // these are only pass throughs
              break;

            default:
              throw new Exception("Unknown Track Piece: " + Current.ToString());
          }

          xPos = xPos + xDot;
          yPos = yPos + yDot;

          if (xPos == StartXPos && yPos == StartYPos)
          {
            done = true;
          }
        }
      }

      public class Train
      {
        public char Letter;
        public int Position;
        public int Direction;
        public int TrackLength;
        public int Length;
        public bool AtStation;
        public int StationTimer;
        public Train(string train, int position, int trackLength)
        {
          Letter = char.ToLower(train[0]);
          Position = position;
          Direction = char.IsUpper(train[0]) ? -1 : 1;
          TrackLength = trackLength;
          Length = train.Length;
          AtStation = false;
          StationTimer = 0;
        }

        public List<int> TrackPositions
        {
          get
          {
            List<int> positions = new List<int>();

            for (int i = 0; i < Length; i++)
            {
              int position = Position + (i * -Direction);

              if (position < 0)
              {
                position = TrackLength + position;
              }
              if (position >= TrackLength)
              {
                position = position - TrackLength;
              }

              positions.Add(position);
            }

            return positions;
          }
        }
      }

      private class TrackPiece
      {
        public int x;
        public int y;
        public int Position;
        public char Piece;
        public TrackPiece(char c, int p, int x, int y)
        {
          Piece = c;
          Position = p;
          this.x = x;
          this.y = y;
        }
      }
    }

  }
}
