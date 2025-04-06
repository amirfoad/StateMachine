
using StateMachine;

Car car = new();

Console.WriteLine($"State: {car.CurrentState}" );

car.TakeAction(Car.Action.Start);
Console.WriteLine($"State: {car.CurrentState}");

car.TakeAction(Car.Action.Start);
Console.WriteLine($"State: {car.CurrentState}");


car.TakeAction(Car.Action.Accelerate);
Console.WriteLine($"State: {car.CurrentState}");


car.TakeAction(Car.Action.Stop);
Console.WriteLine($"State: {car.CurrentState}");