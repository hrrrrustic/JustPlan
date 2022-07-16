module JustPlan.Tasks.Types

open JustPlan.User.Types

type ToDo = {
    Id: int
    Title: string
    Description: string option
    SubToDo: ToDo array option
}

type Assignment = {
    ToDo: ToDo
    Assignee: User
}

type WorkItem =
    | Assignment of Assignment
    | ToDo of ToDo