﻿namespace Balls {
   internal class Program {
      static readonly Ball ball = new Ball();
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
      public event EventHandler BallInPlay;
      public void OnBallInPlay(BallEventArgs e) => BallInPlay?.Invoke(this, e);
   }

   class Pitcher {
      public Pitcher(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;
      private int pitchNumber = 0;
      private void BallInPlayEventHandler(object? sender, EventArgs e) {
         pitchNumber++;
         /*Inside the if statement, we're able to downcast ballEventArgs to type
          BallEventArgs, since BallEventArgs subclasses EventArgs.*/
         if (e is BallEventArgs ballEventArgs) {
            if ((ballEventArgs.Distance < 95) && (ballEventArgs.Angle < 60)) {
               Console.WriteLine($"Pitch #{pitchNumber}: I caught the ball.");
            }
            else {
               Console.WriteLine($"Pitch #{pitchNumber}: I covered first base.");
            }
         }
      }
   }

   class Fan {
      private int pitchNumber = 0;
      public Fan(Ball ball) {
         ball.BallInPlay += BallInPlayEventHandler;
      }

      private void BallInPlayEventHandler(object? sender, EventArgs e) {
         pitchNumber++;
         if (e is BallEventArgs ballEventArgs) {
            if ((ballEventArgs.Distance > 400) && (ballEventArgs.Angle > 30)) {
               Console.WriteLine($"Fan #{pitchNumber}: Home run! I'm going for the ball!");
            }
            else {
               Console.WriteLine($"Fan #{pitchNumber}: Yoo-hoo! Yeah!.");
            }
         }
      }
   }
}