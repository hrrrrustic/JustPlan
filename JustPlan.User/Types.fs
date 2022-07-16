module JustPlan.User.Types

type User = {
    Id: int
    FirstName: string
    LastName: string
    MiddleName: string option
}