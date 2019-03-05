Imports System
Imports Newtonsoft.Json

Module Program
    Sub Main(args As String())
        Dim json = "{'name':'Dark Mystical Cory', 'age':29, 'city':'México','food': ['Tacos', 'Pizza'],'colors': ['black', 'blue', 'yellow']}"
        Dim p = JsonConvert.DeserializeObject(Of Person)(json)
        Console.WriteLine($"Name: {p.name}")
        Console.WriteLine($"Age: {p.age}")
        Console.WriteLine($"City: {p.city}")
        Console.WriteLine("My favorite food:")
        For Each food In p.food
            Console.WriteLine(food)
        Next
        Console.WriteLine("My favorite colors:")
        For Each color In p.colors
            Console.WriteLine(color)
        Next
        Console.ReadKey()
    End Sub

    Public Class Person
        Public Property name As String
        Public Property age As String
        Public Property city As String
        Public Property food As List(Of String)
        Public Property colors As List(Of String)
    End Class
End Module
