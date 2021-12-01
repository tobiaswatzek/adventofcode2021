module Helpers

open Microsoft.FSharp.Collections

let readLines filePath =  System.IO.File.ReadLines(filePath)
