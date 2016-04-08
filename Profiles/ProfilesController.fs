namespace Controllers

open System
open System.Net
open System.Net.Http
open System.Web.Http
open Serilog

type FakeProfile = 
    { Id : Guid
      Name : string }

type ProfilesController() = 
    inherit ApiController()

    member x.Get() = 
        Log.Information("Recived GET request for the one true Profile")
        let oneTrueProfile = 
            { Id = Guid.NewGuid()
              Name = "The One True Profile" }
        x.Request.CreateResponse(oneTrueProfile)
