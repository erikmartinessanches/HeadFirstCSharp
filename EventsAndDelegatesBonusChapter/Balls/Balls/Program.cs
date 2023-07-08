namespace Balls {
   internal class Program {
      static readonly Ball ball = new();
      //Constructors chain their event handlers onto ball's BallInPlay event:
      static readonly Pitcher pitcher = new(ball);
      static readonly Fan fan = new(ball);

      static void Main(string[] args) {
         var running = true;
         while (running) {
            Console.Write("Enter an angle (number) or anything else to quit: ");
            if (int.TryParse(Console.ReadLine(), out int angle)) {
               Console.WriteLine("Enter distance (number) or anything else to quit: ");
               if (int.TryParse(Console.ReadLine(), out int distance)) {
                  BallEventArgs ballEventArgs = new BallEventArgs(angle, distance);
                  ball.OnBallInPlay(ballEventArgs);
               }
               else {
                  running = false;
               }
            }
            else {
               running = false;
            }
         }
         Console.WriteLine("Thanks for playing.");
      }
   }

   class BallEventArgs : EventArgs {
      public int Angle { get; private set; }
      public int Distance { get; private set; }

      public BallEventArgs(int angle, int distance) {
         this.Angle = angle;
         this.Distance = distance;
      }
   }

   class Ball {
      //Generic argument must subclass EventArgs:
      public event EventHandler<BallEventArgs>? BallInPlay;
      public void OnBallInPlay(BallEventArgs e) => BallInPlay?.Invoke(this, e);
   }

   class Pitcher {
      public Pitcher(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;
      private int pitchNumber = 0;
      private void BallInPlayEventHandler(object? sender, BallEventArgs e) {
         pitchNumber++;
         /*Inside the if statement, we're able to downcast ballEventArgs to type
          BallEventArgs, since BallEventArgs subclasses EventArgs. However, if we
         since we passed <BallEventArgs> as the generic param to EventHandler in 
         Ball, this event handler here will always receive EventArgs of type 
         BallEventArgs, so no need to downcast in here. */
         if ((e.Distance < 95) && (e.Angle < 60)) {
            Console.WriteLine($"Pitch #{pitchNumber}: I caught the ball.");
         }
         else {
            Console.WriteLine($"Pitch #{pitchNumber}: I covered first base.");
         }

      }
   }

   class Fan {
      private int pitchNumber = 0;
      public Fan(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;

      private void BallInPlayEventHandler(object? sender, BallEventArgs e) {
         pitchNumber++;
         if ((e.Distance > 400) && (e.Angle > 30)) {
            Console.WriteLine($"Fan #{pitchNumber}: Home run! I'm going for the ball!");
         }
         else {
            Console.WriteLine($"Fan #{pitchNumber}: Yoo-hoo! Yeah!");
         }

      }
   }
}