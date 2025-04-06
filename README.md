# Car State Machine (State Design Pattern)

This repository contains a simple C# implementation of a **State Machine** using the **State Design Pattern** concept. It models the behavior of a car that can be in one of several states: `Stopped`, `Started`, or `Running`, and changes its state based on specific actions.

## Overview

The `Car` class represents a stateful object with the following:

### States

- `Stopped`
- `Started`
- `Running`

### Actions

- `Start`
- `Accelerate`
- `Stop`

State transitions are handled using **C# pattern matching** with a clean and concise switch expression.

## State Transitions

| Current State | Action      | Next State |
|---------------|-------------|------------|
| Stopped       | Start       | Started    |
| Started       | Accelerate  | Running    |
| Started       | Stop        | Stopped    |
| Running       | Stop        | Stopped    |
| *Other*       | *Any*       | No Change  |

## How to Use

You can use the `Car` class like this:

```csharp
using System;
using StateMachine;

class Program
{
    static void Main()
    {
        var car = new Car();
        Console.WriteLine($"Initial State: {car.CurrentState}"); // Stopped

        car.TakeAction(Car.Action.Start);
        Console.WriteLine($"After Start: {car.CurrentState}"); // Started

        car.TakeAction(Car.Action.Accelerate);
        Console.WriteLine($"After Accelerate: {car.CurrentState}"); // Running

        car.TakeAction(Car.Action.Stop);
        Console.WriteLine($"After Stop: {car.CurrentState}"); // Stopped
    }
}