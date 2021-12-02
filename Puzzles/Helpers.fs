module Helpers

open Microsoft.FSharp.Collections

let readLines (filePath:string):seq<string> =  System.IO.File.ReadLines(filePath)
