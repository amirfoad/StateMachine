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

## Code Sample

```csharp
public class Car
{
    public enum State { Stopped, Started, Running }
    public enum Action { Stop, Start, Accelerate }

    private State state = State.Stopped;

    public State CurrentState => state;

    public void TakeAction(Action action)
    {
        state = (state, action) switch
        {
            (State.Stopped, Action.Start) => State.Started,
            (State.Started, Action.Accelerate) => State.Running,
            (State.Started, Action.Stop) => State.Stopped,
            (State.Running, Action.Stop) => State.Stopped,
            _ => state
        };
    }
}