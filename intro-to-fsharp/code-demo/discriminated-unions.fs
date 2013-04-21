module discriminated_unions

open System

//Actually an Enum
type Colour =
    | Red = 0
    | Blue = 1
    | Yellow = 2


// a boring union
type Gender =
    | Male
    | Female

type Appointment =
    | OneTime of DateTime
    | Recurring of DateTime list

type Person =
    {
        Name: string
        Gender: Gender
        Age: int
    }