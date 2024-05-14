namespace App.Controllers

open System.Threading.Tasks
open Microsoft.AspNetCore.Http

module Ping =
  type ResponseJson = { pong: bool }

  let controller(): Task<IResult> =
    task {return Results.Ok { pong = true}}
