open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
open Microsoft.AspNetCore.Http
open App.Controllers
open System.Threading.Tasks

[<EntryPoint>]
let main args =
    let builder = WebApplication.CreateBuilder(args)
    let app = builder.Build()

    app.MapGet("/", Func<string> (fun () -> "Hello World!")) |> ignore
    
    app.MapGet("/ping", Func<Task<IResult>> (fun () -> Ping.controller ()) )
    |> ignore

    app.Run()

    0 // Exit code

