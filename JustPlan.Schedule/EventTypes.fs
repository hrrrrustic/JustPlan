module JustPlan.Calendar.Types

open System

type EventTime = {
    Start: DateTime
    End: DateTime
}

type EventInformation = {
    Title: string
    Description: string option
}

type SingleEvent = {
    Time: EventTime
    Information: EventInformation
}

type RepeatableEvent = {
    InitialTime: EventTime
    Information: EventInformation
    RepeatDelay: TimeSpan
}

type Event =
    | Single of SingleEvent
    | Repeatable of RepeatableEvent