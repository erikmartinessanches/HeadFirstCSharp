/**EVENTS, DELEGATES AND CALLBACKS SUMMARY
 * Delegates is C#'s way of passing references to amethod between objects.
 * 
 *  Events and delegates are part of C# .NET. When an object publishes an event, 
any number of other objects can subscribe to it without the publisher knowing or 
caring. When an event is fired, all subscribers are notified (by calling their 
event handlers). 

 Callbacks are just a name for the way we use delegates (a pattern). A callback
is where one object requests that it be notified by another object. The method
doing the calling of a callback knows and may care about  which method it is 
calling.

 Both callbakcs and events use delegates to reference and call methods in other
objects. */

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
                  var bat = ball.GetNewBat();
                  bat.HitTheBall(ballEventArgs);
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
      protected void OnBallInPlay(BallEventArgs e) => BallInPlay?.Invoke(this, e);
      public Bat GetNewBat() => new Bat(new BatCallback(OnBallInPlay));
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

   /*Callback example follows. With callbacks, the object doing the calling is 
    in control of who is listening. Other objects simply give their delegates and
   ask to be notified. (In contrast, with events, other object demand to be 
   notified by adding event handlers.) */

   //We define the type of callback. When adding a delegate, we create a new type
   //that stores references to methods. 
   delegate void BatCallback(BallEventArgs e);

   class Bat {
      private BatCallback hitBallCallback; //A property holding a callback
      //We get the function to call from outside and store it in a prop.
      public Bat(BatCallback callbackDelegate) =>
         this.hitBallCallback = callbackDelegate;
      //We invoke hitBallCallback when HitTHeBall is run.
      public void HitTheBall(BallEventArgs e) => hitBallCallback?.Invoke(e);
   }
}