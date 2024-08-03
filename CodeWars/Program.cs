// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;
using System.Text;
using CodeWars;
using CodeWars.Solutions;

var matrix = new List<List<int>>
{
    new() { 5, 3, 4 },
    new() { 1, 5, 8 },
    new() { 6, 4, 2 },
};
var result = MagicSquare.Solution(matrix);
Console.Write("");